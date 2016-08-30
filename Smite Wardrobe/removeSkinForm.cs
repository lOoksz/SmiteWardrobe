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
    public partial class removeSkinForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        public removeSkinForm()
        {
            InitializeComponent();
        }

        private void removeSkinForm_Load(object sender, EventArgs e)
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
                    removeSkinGodComboBox.Items.Add(reader["God"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in remove god form combo box! " + ex);
                con.Close();
            }
        }

        private void removeSkinGodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string selectedGod = removeSkinGodComboBox.Text;
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select * from [{0}]", selectedGod);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                //Reading and updating acquired skins box
                removeSkinNameComboBox.Update();
                removeSkinNameComboBox.Items.Clear();

                while (reader.Read())
                {
                    removeSkinNameComboBox.Items.Add(reader["Skins"]);
                }

                removeSkinNameComboBox.EndUpdate();

                removeSkinNameComboBox.SelectedIndex = 0;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating remove skin name combo box! " + ex);
                con.Close();
            }
        }

        private void removeSkinButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = String.Format("DELETE FROM [{0}] WHERE Skins='{1}'", removeSkinGodComboBox.Text, removeSkinNameComboBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in remove skin button press (delete from relevant God)! " + ex);
                con.Close();
            }
        }
    }
}
