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
    public partial class Form1 : Form
    {
        //exe icon provided by user Udelude @ Smite Forum http://forums.smitegame.com/showthread.php?76879-SMITE-Flat-Icon

        //Global connection variable so multiple functions can use it
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        List<string> allAcquiredSkinsList = new List<string>();
        List<string> godsList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=smiteDatabase.accdb;Persist Security Info=False;";
                con.Open();
                checkConnectionLabel.Text = "Connected to database";
                cmd.Connection = con;
                string query = "select * from All_Gods";
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    godsList.Add(reader["God"].ToString());
                    godsListComboBox.Items.Add(reader["God"]);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't locate smite database file, did you remove it from the database folder?");
                checkConnectionLabel.Text = "Database Error (NO CHANGES WILL BE SAVED).";
                con.Close();
            }
            
            try
            {
                con.Open();
                cmd.Connection = con;

                foreach (string god in godsList)
                {
                    string query = String.Format("select Skins from [{0}] where Acquired=True", god);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        allAcquiredSkinsList.Add(god + " - " + reader["Skins"]);
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string selectedGod = godsListComboBox.Text;
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select * from [{0}]", selectedGod);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                //Reading and updating acquired skins box
                skinsAcquiredListBox.Update();
                skinsAcquiredListBox.Items.Clear();

                while (reader.Read())
                {
                    skinsAcquiredListBox.Items.Add(reader["Skins"]);
                    skinsAcquiredListBox.SetItemChecked(skinsAcquiredListBox.Items.IndexOf(reader.GetString(0)), reader.GetBoolean(1));
                }

                skinsAcquiredListBox.EndUpdate();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ryan's Error Catcher:\n\n" + ex);
                con.Close();
            }
        }

        private void skinsAcquiredListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGod = godsListComboBox.GetItemText(godsListComboBox.SelectedItem);
            bool skinIsAcquired;
            string selectedSkin = skinsAcquiredListBox.GetItemText(skinsAcquiredListBox.SelectedItem);

            if (skinsAcquiredListBox.CheckedItems.Contains(skinsAcquiredListBox.SelectedItem))
                skinIsAcquired = true;
            else
                skinIsAcquired = false;

            con.Open();
            selectedSkin = selectedSkin.Replace("'", "''");
            string query = String.Format("update [{0}] set Acquired={1} where Skins='{2}'", selectedGod, skinIsAcquired, selectedSkin);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            try
            {
                con.Open();
                cmd.Connection = con;

                foreach (string god in godsListComboBox.Items)
                {
                    query = String.Format("select Skins from [{0}] where Acquired=True", god);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        allAcquiredSkinsList.Add(god + " - " + reader["Skins"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred when updating all skins acquired listbox.");
                con.Close();
            }
        }

        #region godIconButtons

        private void agni_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Agni");
        }

        private void ah_muzen_cab_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ah Muzen Cab");
        }

        private void ah_puch_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ah Puch");
        }

        private void amaterasu_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Amaterasu");
        }

        private void anhur_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Anhur");
        }

        private void anubis_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Anubis");
        }

        private void ao_kuang_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ao Kuang");
        }

        private void aphrodite_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Aphrodite");
        }

        private void apollo_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Apollo");
        }

        private void arachne_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Arachne");
        }

        private void ares_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ares");
        }

        private void artemis_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Artemis");
        }

        private void athena_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Athena");
        }

        private void awilix_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Awilix");
        }

        private void bacchus_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Bacchus");
        }

        private void bakasura_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Bakasura");
        }

        private void bastet_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Bastet");
        }

        private void bellona_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Bellona");
        }

        private void cabrakan_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Cabrakan");
        }

        private void chaac_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Chaac");
        }

        private void change_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Chang'e");
        }

        private void chiron_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Chiron");
        }

        private void chronos_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Chronos");
        }

        private void cupid_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Cupid");
        }

        private void erlang_shen_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Erlang Shen");
        }

        private void fafnir_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Fafnir");
        }

        private void fenrir_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Fenrir");
        }

        private void freya_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Freya");
        }

        private void geb_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Geb");
        }

        private void guan_yu_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Guan Yu");
        }

        private void hades_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Hades");
        }

        private void he_bo_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("He Bo");
        }

        private void hel_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Hel");
        }

        private void hercules_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Hercules");
        }

        private void hou_yi_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Hou Yi");
        }

        private void hun_batz_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Hun Batz");
        }

        private void isis_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Isis");
        }

        private void izanami_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Izanami");
        }

        private void janus_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Janus");
        }

        private void jing_wei_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Jing Wei");
        }

        private void kali_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Kali");
        }

        private void khepri_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Khepri");
        }

        private void kukulkan_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Kukulkan");
        }

        private void kumbakharna_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Kumbhakarna");
        }

        private void loki_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Loki");
        }

        private void medusa_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Medusa");
        }

        private void mercury_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Mercury");
        }

        private void neith_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Neith");
        }

        private void nemesis_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Nemesis");
        }

        private void ne_zha_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ne Zha");
        }

        private void nox_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Nox");
        }

        private void nu_wa_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Nu Wa");
        }

        private void odin_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Odin");
        }

        private void osiris_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Osiris");
        }

        private void poseidon_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Poseidon");
        }

        private void ra_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ra");
        }

        private void raijin_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Raijin");
        }

        private void rama_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Rama");
        }

        private void ratatoskr_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ratatoskr");
        }

        private void ravana_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ravana");
        }

        private void scylla_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Scylla");
        }

        private void serqet_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Serqet");
        }

        private void skadi_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Skadi");
        }

        private void sobek_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Sobek");
        }

        private void sol_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Sol");
        }

        private void sun_wukong_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Sun Wukong");
        }

        private void susano_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Susano");
        }

        private void sylvanus_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Sylvanus");
        }

        private void terra_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Terra");
        }

        private void thanatos_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Thanatos");
        }

        private void thor_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Thor");
        }

        private void tyr_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Tyr");
        }

        private void ullr_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ullr");
        }

        private void vamana_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Vamana");
        }

        private void vulcan_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Vulcan");
        }

        private void xbalanque_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Xbalanque");
        }

        private void xing_tian_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Xing Tian");
        }

        private void ymir_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Ymir");
        }

        private void zeus_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Zeus");
        }

        private void zhong_kui_Click(object sender, EventArgs e)
        {
            godsListComboBox.SelectedIndex = godsListComboBox.FindStringExact("Zhong Kui");
        }

        #endregion

        private void showAllSkinsButton_Click(object sender, EventArgs e)
        {
            StringBuilder allSkins = new StringBuilder();

            allSkins.AppendLine("You have " + allAcquiredSkinsList.Count.ToString() + " Skins.\n");
            foreach (string skin in allAcquiredSkinsList)
            {
                allSkins.AppendLine(skin);
            }

            Wardrobe wardrobe = new Wardrobe();
            wardrobe.ShowDialog();
        }

        private void godsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string selectedGod = godsListComboBox.GetItemText(godsListComboBox.SelectedItem);
                cmd.Connection = con;

                //Constructing SQL Query
                string query = String.Format("select * from [{0}]", selectedGod);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //Making reader object
                OleDbDataReader reader = cmd.ExecuteReader();

                //Reading and updating acquired skins box
                skinsAcquiredListBox.Update();
                skinsAcquiredListBox.Items.Clear();

                while (reader.Read())
                {
                    skinsAcquiredListBox.Items.Add(reader["Skins"]);
                    skinsAcquiredListBox.SetItemChecked(skinsAcquiredListBox.Items.IndexOf(reader.GetString(0)), reader.GetBoolean(1));
                }

                skinsAcquiredListBox.EndUpdate();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ryan's Error Catcher:\n\n" + ex);
                con.Close();
            }
        }

        private void randomGodGeneratorFormShow_Click(object sender, EventArgs e)
        {
            RandomGodGenerator rgg = new RandomGodGenerator();
            rgg.ShowDialog();
        }

        private void addGodToDatabase_Click(object sender, EventArgs e)
        {
            addGodToDatabaseForm agtd = new addGodToDatabaseForm();
            agtd.ShowDialog();
        }

        private void addNewGodToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addGodToDatabaseForm agtd = new addGodToDatabaseForm();
            agtd.ShowDialog();
        }

        private void addNewSkinToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSkinToDatabaseForm astd = new addSkinToDatabaseForm();
            astd.ShowDialog();
        }

        private void removeGodFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeGodForm rgf = new removeGodForm();
            rgf.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ryan Sainty.\n\nThis was made as a personal project because smite doesn't offer a method of seeing all the skins you own in one place.\n\nContact me at:\n\n/u/RevyCSGO\n@Lumbridge (github)\n@_RarePepe (Twitter)\n");
        }

        private void randomGodGeneratorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RandomGodGenerator rgg = new RandomGodGenerator();
            rgg.ShowDialog();
        }

        private void showSkinCollectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Wardrobe wardrobe = new Wardrobe();
            wardrobe.ShowDialog();
        }

        private void removeSkinFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeSkinForm rsf = new removeSkinForm();
            rsf.ShowDialog();
        }
    }
}