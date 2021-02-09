using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RajongoiKlub
{
    public partial class TagBefizetesFelvetele : Form
    {
        public TagBefizetesFelvetele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.nyito.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nev = textBox_nev.Text.Trim();
            int osszeg = (int) numericUpDown1.Value;

            if (String.IsNullOrEmpty(nev))
            {
                MessageBox.Show("A teljes név megadása kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_nev.Focus();
                return;
            }

            if(osszeg == 0)
            {
                MessageBox.Show("Adjon meg egy nagyobb összeget!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Focus();
                return;
            }
            
            Program.sql.CommandText = "INSERT INTO `befizetes`(`u_azon`, `datum`, `osszeg`) " +
                "VALUES((SELECT `azon` FROM `tagok` WHERE `nev` = '" + nev + "'), '" + dateTimePicker_datum.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " + osszeg + ");";
            Program.sql.ExecuteNonQuery();

            MessageBox.Show("Sikeres felvétel!", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_nev.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;

            dataGridView_Tagok.Rows.Clear();
            tablaFeltoltes();
        }

        private void TagBefizetesFelvetele_Load(object sender, EventArgs e)
        {
            dataGridView_Tagok.ColumnCount = 3;
            dataGridView_Tagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Tagok.Columns[0].Name = "nev";
            dataGridView_Tagok.Columns[0].HeaderText = "Teljes név";

            dataGridView_Tagok.Columns[1].Name = "befiz";
            dataGridView_Tagok.Columns[1].HeaderText = "Befizetett összeg";

            dataGridView_Tagok.Columns[2].Name = "datum";
            dataGridView_Tagok.Columns[2].HeaderText = "Dátum";

            tablaFeltoltes();
        }

        private void tablaFeltoltes()
        {
            try
            {

                Program.sql.CommandText = "SELECT  tagok.nev, befizetes.osszeg, befizetes.datum FROM tagok JOIN befizetes ON befizetes.u_azon = tagok.azon";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_Tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_Tagok.Rows[uj_sor_indexe];

                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["befiz"].Value = dr.GetInt32("osszeg");
                        uj_sor.Cells["datum"].Value = dr.GetString("datum");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                throw;
            }
        }
    }
}
