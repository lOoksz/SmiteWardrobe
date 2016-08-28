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
    public partial class RandomGodGenerator : Form
    {
        static Random rnd = new Random();

        //Global connection variable so multiple functions can use it
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        //All lists initialization
        List<string> gods_all = new List<string>();
        List<string> gods_guardian = new List<string>();
        List<string> gods_hunter = new List<string>();
        List<string> gods_mage = new List<string>();
        List<string> gods_assassin = new List<string>();
        List<string> gods_warrior = new List<string>();

        public RandomGodGenerator()
        {
            InitializeComponent();
        }

        private void RandomGodGenerator_Load(object sender, EventArgs e)
        {
            classComboBox.SelectedIndex = 0;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/smiteDatabase.accdb;Persist Security Info=False;";
            #region god_lists
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
                    gods_all.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding all gods from database to internal list, is the database missing?");
                con.Close();
            }

            //Guardians List
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods where Class='Guardian'");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gods_guardian.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding guardian gods from database to internal list, is the database missing?");
                con.Close();
            }

            //Hunter List
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods where Class='Hunter'");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gods_hunter.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding hunter gods from database to internal list, is the database missing?");
                con.Close();
            }

            //Assassin List
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods where Class='Assassin'");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gods_assassin.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding assassin gods from database to internal list, is the database missing?");
                con.Close();
            }

            //Mage List
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods where Class='Mage'");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gods_mage.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding assassin gods from database to internal list, is the database missing?");
                con.Close();
            }

            //Warrior List
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select God from All_Gods where Class='Warrior'");
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gods_warrior.Add(reader["God"].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding warrior gods from database to internal list, is the database missing?");
                con.Close();
            }
            #endregion
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (classComboBox.SelectedIndex == 0)
            {
                int r = rnd.Next(gods_all.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_all[r];
            }
            else if (classComboBox.SelectedIndex == 1)
            {
                int r = rnd.Next(gods_assassin.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_assassin[r];
            }
            else if (classComboBox.SelectedIndex == 2)
            {
                int r = rnd.Next(gods_guardian.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_guardian[r];
            }
            else if (classComboBox.SelectedIndex == 3)
            {
                int r = rnd.Next(gods_hunter.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_hunter[r];
            }
            else if (classComboBox.SelectedIndex == 4)
            {
                int r = rnd.Next(gods_warrior.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_mage[r];
            }
            else if (classComboBox.SelectedIndex == 5)
            {
                int r = rnd.Next(gods_warrior.Count);
                RandomGodGeneratedLabel.Text = "Random God: " + gods_warrior[r];
            }
        }
    }
}
