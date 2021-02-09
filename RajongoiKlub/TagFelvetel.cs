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
    public partial class TagFelvetel : Form
    {
        public TagFelvetel()
        {
            InitializeComponent();
        }

        private void button_Felvetel_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_Tnev.Text.Trim()))
            {
                MessageBox.Show("A teljes név megadása kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Tnev.Focus();
                return; 
            }

            if(numericUpDown_Irszam.Value == 0)
            {
                MessageBox.Show("Érvényes irányitó számot adjon meg!", "Érvénytelen adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_Irszam.Focus();
                return;
            }

            if (String.IsNullOrEmpty(textBox_Orszag.Text.Trim()))
            {
                MessageBox.Show("Az ország megadása kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Orszag.Focus();
                return;
            }

            string teljes_nev = textBox_Tnev.Text;
            int irszam = (int) numericUpDown_Irszam.Value;
            int szulev = (int) numericUpDown1.Value;
            string orszag = textBox_Orszag.Text;

            Program.sql.CommandText = "INSERT INTO `tagok`(`nev`, `szulev`, `irszam`, `orsz`) " +
                "VALUES ('"+ teljes_nev +"', '" + szulev + "', '"+ irszam + "', '"+ orszag + "');";
            Program.sql.ExecuteNonQuery();

            MessageBox.Show("Sikeres felvétel", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_Orszag.Clear();
            textBox_Tnev.Clear();
            numericUpDown_Irszam.Value = numericUpDown_Irszam.Minimum;
            numericUpDown1.Value = numericUpDown1.Minimum;

            dataGridView_Tagok.Rows.Clear();
            tablaFeltoltes();
        }

        private void button_Vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.nyito.Show();
        }

        private void TagFelvetel_Load(object sender, EventArgs e)
        {
            dataGridView_Tagok.ColumnCount = 4;
            dataGridView_Tagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Tagok.Columns[0].Name = "nev";
            dataGridView_Tagok.Columns[0].HeaderText = "Teljes név";

            dataGridView_Tagok.Columns[1].Name = "szulev";
            dataGridView_Tagok.Columns[1].HeaderText = "Születési év";

            dataGridView_Tagok.Columns[2].Name = "irszam";
            dataGridView_Tagok.Columns[2].HeaderText = "Irányítószám";

            dataGridView_Tagok.Columns[3].Name = "orsz";
            dataGridView_Tagok.Columns[3].HeaderText = "Ország";

            tablaFeltoltes();
        }

        private void tablaFeltoltes()
        {
            try
            {

                Program.sql.CommandText = "SELECT `nev`, `szulev`, `irszam`, `orsz` FROM `tagok` WHERE 1";
                using(MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_Tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_Tagok.Rows[uj_sor_indexe];

                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["szulev"].Value = dr.GetInt32("szulev");
                        uj_sor.Cells["irszam"].Value = dr.GetInt32("irszam");
                        uj_sor.Cells["orsz"].Value = dr.GetString("orsz");

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
