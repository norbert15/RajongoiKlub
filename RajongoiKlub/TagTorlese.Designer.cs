namespace RajongoiKlub
{
    partial class TagTorlese
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Tagok = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Tnev = new System.Windows.Forms.TextBox();
            this.textBox_Orszag = new System.Windows.Forms.TextBox();
            this.numericUpDown_SzulEv = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_irszam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_azon = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_azon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tagok törlése";
            // 
            // dataGridView_Tagok
            // 
            this.dataGridView_Tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tagok.Location = new System.Drawing.Point(12, 271);
            this.dataGridView_Tagok.Name = "dataGridView_Tagok";
            this.dataGridView_Tagok.Size = new System.Drawing.Size(638, 297);
            this.dataGridView_Tagok.TabIndex = 1;
            this.dataGridView_Tagok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tagok_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Azonosító:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teljes név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Születési Év:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Irányító szám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ország:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vissza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Tnev
            // 
            this.textBox_Tnev.Enabled = false;
            this.textBox_Tnev.Location = new System.Drawing.Point(152, 109);
            this.textBox_Tnev.Name = "textBox_Tnev";
            this.textBox_Tnev.Size = new System.Drawing.Size(159, 29);
            this.textBox_Tnev.TabIndex = 9;
            // 
            // textBox_Orszag
            // 
            this.textBox_Orszag.Enabled = false;
            this.textBox_Orszag.Location = new System.Drawing.Point(152, 158);
            this.textBox_Orszag.Name = "textBox_Orszag";
            this.textBox_Orszag.Size = new System.Drawing.Size(159, 29);
            this.textBox_Orszag.TabIndex = 10;
            // 
            // numericUpDown_SzulEv
            // 
            this.numericUpDown_SzulEv.Enabled = false;
            this.numericUpDown_SzulEv.Location = new System.Drawing.Point(485, 69);
            this.numericUpDown_SzulEv.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown_SzulEv.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown_SzulEv.Name = "numericUpDown_SzulEv";
            this.numericUpDown_SzulEv.Size = new System.Drawing.Size(159, 29);
            this.numericUpDown_SzulEv.TabIndex = 11;
            this.numericUpDown_SzulEv.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // numericUpDown_irszam
            // 
            this.numericUpDown_irszam.Enabled = false;
            this.numericUpDown_irszam.Location = new System.Drawing.Point(485, 109);
            this.numericUpDown_irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_irszam.Name = "numericUpDown_irszam";
            this.numericUpDown_irszam.Size = new System.Drawing.Size(159, 29);
            this.numericUpDown_irszam.TabIndex = 12;
            this.numericUpDown_irszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_azon
            // 
            this.numericUpDown_azon.Enabled = false;
            this.numericUpDown_azon.Location = new System.Drawing.Point(152, 69);
            this.numericUpDown_azon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_azon.Name = "numericUpDown_azon";
            this.numericUpDown_azon.Size = new System.Drawing.Size(159, 29);
            this.numericUpDown_azon.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Tag Törlése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TagTorlese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown_azon);
            this.Controls.Add(this.numericUpDown_irszam);
            this.Controls.Add(this.numericUpDown_SzulEv);
            this.Controls.Add(this.textBox_Orszag);
            this.Controls.Add(this.textBox_Tnev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Tagok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TagTorlese";
            this.Text = "TagTorlese";
            this.Load += new System.EventHandler(this.TagTorlese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_azon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Tagok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Tnev;
        private System.Windows.Forms.TextBox textBox_Orszag;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzulEv;
        private System.Windows.Forms.NumericUpDown numericUpDown_irszam;
        private System.Windows.Forms.NumericUpDown numericUpDown_azon;
        private System.Windows.Forms.Button button2;
    }
}