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
    public partial class TagKreditKiszamitas : Form
    {
        public TagKreditKiszamitas()
        {
            InitializeComponent();
        }

        private void TagKreditKiszamitas_Load(object sender, EventArgs e)
        {
            dataGridView_Tagok.ColumnCount = 3;
            dataGridView_Tagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Tagok.Columns[0].Name = "azon";
            dataGridView_Tagok.Columns[0].HeaderText = "Azonosító";

            dataGridView_Tagok.Columns[1].Name = "nev";
            dataGridView_Tagok.Columns[1].HeaderText = "Teljes név";

            dataGridView_Tagok.Columns[2].Name = "kredit";
            dataGridView_Tagok.Columns[2].HeaderText = "Kredit";

            tablaFeltoltes();
        }

        private void tablaFeltoltes()
        {
            try
            {

                Program.sql.CommandText = "SELECT tagok.azon, tagok.nev, " +
                "SUM(befizetes.osszeg) AS kredit FROM tagok JOIN befizetes " +
                "ON befizetes.u_azon = tagok.azon GROUP BY 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_Tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_Tagok.Rows[uj_sor_indexe];

                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["kredit"].Value =(double) dr.GetInt32("kredit")/1000;

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
