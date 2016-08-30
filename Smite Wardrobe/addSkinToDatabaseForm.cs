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
    public partial class addSkinToDatabaseForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        public addSkinToDatabaseForm()
        {
            InitializeComponent();
        }

        private void addSkinToDatabaseForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=smiteDatabase.accdb;Persist Security Info=False;";

            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "select * from All_Gods";
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    newGodSkinComboBox.Items.Add(reader["God"]);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in add skin to database combo box! " + ex);
                con.Close();
            }

        }

        private void addSkinButton_Click(object sender, EventArgs e)
        {
            //Add skin to relevant God's table
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("INSERT INTO [{0}] ([Skins]) VALUES ('{1}')", newGodSkinComboBox.Text, newSkinTextBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding new god to database, does it already exist?" + ex);
                con.Close();
            }
        }

        private void newGodSkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
