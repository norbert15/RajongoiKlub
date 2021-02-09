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
    public partial class TagTorlese : Form
    {
        public TagTorlese()
        {
            InitializeComponent();
        }

        private void TagTorlese_Load(object sender, EventArgs e)
        {
            dataGridView_Tagok.ColumnCount = 5;
            dataGridView_Tagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Tagok.Columns[0].Name = "azon";
            dataGridView_Tagok.Columns[0].HeaderText = "Azonosító";

            dataGridView_Tagok.Columns[1].Name = "nev";
            dataGridView_Tagok.Columns[1].HeaderText = "Teljes név";

            dataGridView_Tagok.Columns[2].Name = "szulev";
            dataGridView_Tagok.Columns[2].HeaderText = "Születési év";

            dataGridView_Tagok.Columns[3].Name = "irszam";
            dataGridView_Tagok.Columns[3].HeaderText = "Irányítószám";

            dataGridView_Tagok.Columns[4].Name = "orsz";
            dataGridView_Tagok.Columns[4].HeaderText = "Ország";

            tablaFeltoltes();
        }

        private void tablaFeltoltes()
        {
            try
            {

                Program.sql.CommandText = "SELECT azon, `nev`, `szulev`, `irszam`, `orsz` FROM `tagok` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_Tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_Tagok.Rows[uj_sor_indexe];

                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
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

        private void dataGridView_Tagok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow uj_sor = dataGridView_Tagok.Rows[e.RowIndex];

            numericUpDown_azon.Value = (int) uj_sor.Cells["azon"].Value;
            textBox_Tnev.Text = uj_sor.Cells["nev"].Value.ToString();
            numericUpDown_SzulEv.Value = (int) uj_sor.Cells["szulev"].Value;
            numericUpDown_irszam.Value = (int) uj_sor.Cells["irszam"].Value;
            textBox_Orszag.Text = uj_sor.Cells["orsz"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(numericUpDown_azon.Value == 0)
            {
                MessageBox.Show("Válasszon a táblázatból tagot a törléshez!", "Helytele azonosító!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.sql.CommandText = "DELETE FROM `tagok` WHERE `azon` = '" + numericUpDown_azon.Value + "'";
            Program.sql.ExecuteNonQuery();

            MessageBox.Show("Sikeres törlés!", "Visszajelzés!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView_Tagok.Rows.Clear();
            tablaFeltoltes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.nyito.Show();
        }
    }
}
