using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Smite_Wardrobe
{
    public partial class Wardrobe : Form
    {
        //Global connection variable so multiple functions can use it
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        List<string> allGods = new List<string>();
        List<string> allSkins = new List<string>();

        public Wardrobe()
        {
            InitializeComponent();
        }

        private void Wardrobe_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=smiteDatabase.accdb;Persist Security Info=False;";

            //All gods list
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allGods.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding all gods from database to internal list, is the database missing?");
                con.Close();
            }

            WardrobeListView.View = View.Details;
            WardrobeListView.GridLines = true;
            WardrobeListView.FullRowSelect = true;

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            try
            {
                con.Open();
                cmd.Connection = con;

                foreach (string god in allGods)
                {
                    string query = String.Format("select Skins from [{0}] where Acquired=True", god);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        arr[0] = god;
                        arr[1] = reader["Skins"].ToString();
                        itm = new ListViewItem(arr);
                        WardrobeListView.Items.Add(itm);
                    }
                    reader.Close();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred when initializing all skins acquired listbox.");
                con.Close();
            }

            //update skin count label
            skinCountLabel.Text = "Skin Count: " + WardrobeListView.Items.Count.ToString();
        }
    }
}
