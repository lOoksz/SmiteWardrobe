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
    public partial class removeGodForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        public removeGodForm()
        {
            InitializeComponent();
        }

        private void removeGodForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/smiteDatabase.accdb;Persist Security Info=False;";

            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "select * from All_Gods";
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    removeGodComboBox.Items.Add(reader["God"]);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in remove god form combo box! " + ex);
                con.Close();
            }
        }

        private void removeGodButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = String.Format("DELETE FROM All_Gods WHERE God='{0}'", removeGodComboBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in remove god button press (delete from All_Gods)! " + ex);
                con.Close();
            }

            try
            {
                con.Open();
                cmd.Connection = con;
                string query = String.Format("drop table [{0}]", removeGodComboBox.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();

                //Restart if successfull
                try
                {
                    MessageBox.Show(String.Format("{0} removed successfully. Restarting program.", removeGodComboBox.Text));
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred in restarting the program, please manually restart the program. " + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in remove god button press (delete relevant God table)! " + ex);
                con.Close();
            }
        }
    }
}
