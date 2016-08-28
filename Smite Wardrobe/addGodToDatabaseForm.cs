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
    public partial class addGodToDatabaseForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        public addGodToDatabaseForm()
        {
            InitializeComponent();
        }

        private void addGodToDatabaseForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/smiteDatabase.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add God Table
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("CREATE TABLE [{0}](Skins TEXT(100) NOT NULL, Acquired YESNO NOT NULL)", newGodNameTextBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding new god to database, does it already exist?" + ex);
                con.Close();
            }

            //Add to all_gods table
            try
            {
                con.Open();
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("INSERT INTO All_Gods ([God], [Pantheon], [Attack Type], [Power Type], [Class]) VALUES ('{0}','{1}','{2}','{3}','{4}')", newGodNameTextBox.Text, newGodPantheonComboBox.Text, newGodAttackTypeComboBox.Text, newGodPowerTypeComboBox.Text, newGodClassComboBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();

                //Restart if successfull
                try
                {
                    MessageBox.Show(String.Format("{0} added successfully. Restarting program.", newGodNameTextBox.Text));
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred in restarting the program, please manually restart the program. " + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding new god to database, does it already exist?" + ex);
                con.Close();
            }
        }
    }
}
