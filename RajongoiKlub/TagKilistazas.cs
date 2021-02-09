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
    public partial class TagKilistazas : Form
    {
        public TagKilistazas()
        {
            InitializeComponent();
        }

        private void TagKilistazas_Load(object sender, EventArgs e)
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
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.nyito.Show();
        }
    }
}
