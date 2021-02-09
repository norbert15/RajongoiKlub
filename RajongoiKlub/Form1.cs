using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajongoiKlub
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void tagokBefizetéseinekFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagBefizetes.Show();
        }

        private void tagFelvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagFelvetel.Show();
        }

        private void tagTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagTorlese.Show();
        }

        private void tagokKilistázásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagKilistazas.Show();
        }

        private void tagokKreditjeinekKiszámításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagKreditKiszamitas.Show();
        }
    }
}
