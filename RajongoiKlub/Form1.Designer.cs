namespace RajongoiKlub
{
    partial class Form_Nyito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tagFelvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagokBefizetéseinekFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagokKilistázásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagokKreditjeinekKiszámításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagFelvételToolStripMenuItem,
            this.tagTörléseToolStripMenuItem,
            this.tagokBefizetéseinekFelvételeToolStripMenuItem,
            this.tagokKilistázásaToolStripMenuItem,
            this.tagokKreditjeinekKiszámításaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tagFelvételToolStripMenuItem
            // 
            this.tagFelvételToolStripMenuItem.Name = "tagFelvételToolStripMenuItem";
            this.tagFelvételToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.tagFelvételToolStripMenuItem.Text = "Tag felvétele az adatbázisba";
            this.tagFelvételToolStripMenuItem.Click += new System.EventHandler(this.tagFelvételToolStripMenuItem_Click);
            // 
            // tagTörléseToolStripMenuItem
            // 
            this.tagTörléseToolStripMenuItem.Name = "tagTörléseToolStripMenuItem";
            this.tagTörléseToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.tagTörléseToolStripMenuItem.Text = "Tag törlése az adatbáziból";
            this.tagTörléseToolStripMenuItem.Click += new System.EventHandler(this.tagTörléseToolStripMenuItem_Click);
            // 
            // tagokBefizetéseinekFelvételeToolStripMenuItem
            // 
            this.tagokBefizetéseinekFelvételeToolStripMenuItem.Name = "tagokBefizetéseinekFelvételeToolStripMenuItem";
            this.tagokBefizetéseinekFelvételeToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.tagokBefizetéseinekFelvételeToolStripMenuItem.Text = "Tagok befizetéseinek felvétele ";
            this.tagokBefizetéseinekFelvételeToolStripMenuItem.Click += new System.EventHandler(this.tagokBefizetéseinekFelvételeToolStripMenuItem_Click);
            // 
            // tagokKilistázásaToolStripMenuItem
            // 
            this.tagokKilistázásaToolStripMenuItem.Name = "tagokKilistázásaToolStripMenuItem";
            this.tagokKilistázásaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.tagokKilistázásaToolStripMenuItem.Text = "Tagok kilistázása";
            this.tagokKilistázásaToolStripMenuItem.Click += new System.EventHandler(this.tagokKilistázásaToolStripMenuItem_Click);
            // 
            // tagokKreditjeinekKiszámításaToolStripMenuItem
            // 
            this.tagokKreditjeinekKiszámításaToolStripMenuItem.Name = "tagokKreditjeinekKiszámításaToolStripMenuItem";
            this.tagokKreditjeinekKiszámításaToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.tagokKreditjeinekKiszámításaToolStripMenuItem.Text = "Tagok kreditjeinek kiszámítása ";
            this.tagokKreditjeinekKiszámításaToolStripMenuItem.Click += new System.EventHandler(this.tagokKreditjeinekKiszámításaToolStripMenuItem_Click);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tagFelvételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagokBefizetéseinekFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagokKilistázásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagokKreditjeinekKiszámításaToolStripMenuItem;
    }
}

