namespace RajongoiKlub
{
    partial class TagFelvetel
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Tnev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Irszam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Orszag = new System.Windows.Forms.TextBox();
            this.button_Felvetel = new System.Windows.Forms.Button();
            this.dataGridView_Tagok = new System.Windows.Forms.DataGridView();
            this.button_Vissza = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Irszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag Felvétel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teljes név:";
            // 
            // textBox_Tnev
            // 
            this.textBox_Tnev.Location = new System.Drawing.Point(358, 64);
            this.textBox_Tnev.Name = "textBox_Tnev";
            this.textBox_Tnev.Size = new System.Drawing.Size(195, 29);
            this.textBox_Tnev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Születési év:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Irányítószám:";
            // 
            // numericUpDown_Irszam
            // 
            this.numericUpDown_Irszam.Location = new System.Drawing.Point(358, 142);
            this.numericUpDown_Irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_Irszam.Name = "numericUpDown_Irszam";
            this.numericUpDown_Irszam.Size = new System.Drawing.Size(195, 29);
            this.numericUpDown_Irszam.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ország:";
            // 
            // textBox_Orszag
            // 
            this.textBox_Orszag.Location = new System.Drawing.Point(358, 177);
            this.textBox_Orszag.Name = "textBox_Orszag";
            this.textBox_Orszag.Size = new System.Drawing.Size(195, 29);
            this.textBox_Orszag.TabIndex = 8;
            // 
            // button_Felvetel
            // 
            this.button_Felvetel.Location = new System.Drawing.Point(274, 237);
            this.button_Felvetel.Name = "button_Felvetel";
            this.button_Felvetel.Size = new System.Drawing.Size(137, 41);
            this.button_Felvetel.TabIndex = 9;
            this.button_Felvetel.Text = "TagFelvétele";
            this.button_Felvetel.UseVisualStyleBackColor = true;
            this.button_Felvetel.Click += new System.EventHandler(this.button_Felvetel_Click);
            // 
            // dataGridView_Tagok
            // 
            this.dataGridView_Tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tagok.Location = new System.Drawing.Point(3, 297);
            this.dataGridView_Tagok.Name = "dataGridView_Tagok";
            this.dataGridView_Tagok.Size = new System.Drawing.Size(690, 201);
            this.dataGridView_Tagok.TabIndex = 10;
            // 
            // button_Vissza
            // 
            this.button_Vissza.Location = new System.Drawing.Point(12, 12);
            this.button_Vissza.Name = "button_Vissza";
            this.button_Vissza.Size = new System.Drawing.Size(117, 36);
            this.button_Vissza.TabIndex = 11;
            this.button_Vissza.Text = "Vissza";
            this.button_Vissza.UseVisualStyleBackColor = true;
            this.button_Vissza.Click += new System.EventHandler(this.button_Vissza_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(358, 104);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 29);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // TagFelvetel
            // 
            this.ClientSize = new System.Drawing.Size(705, 510);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_Vissza);
            this.Controls.Add(this.dataGridView_Tagok);
            this.Controls.Add(this.button_Felvetel);
            this.Controls.Add(this.textBox_Orszag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_Irszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tnev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "TagFelvetel";
            this.Load += new System.EventHandler(this.TagFelvetel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Irszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Tnev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Irszam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Orszag;
        private System.Windows.Forms.Button button_Felvetel;
        private System.Windows.Forms.DataGridView dataGridView_Tagok;
        private System.Windows.Forms.Button button_Vissza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}