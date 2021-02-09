namespace RajongoiKlub
{
    partial class TagBefizetesFelvetele
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
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_Tagok = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Befizetés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dátum:";
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datum.Location = new System.Drawing.Point(324, 116);
            this.dateTimePicker_datum.MaxDate = new System.DateTime(2021, 2, 20, 0, 0, 0, 0);
            this.dateTimePicker_datum.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.RightToLeftLayout = true;
            this.dateTimePicker_datum.Size = new System.Drawing.Size(183, 29);
            this.dateTimePicker_datum.TabIndex = 2;
            this.dateTimePicker_datum.Value = new System.DateTime(2021, 2, 9, 16, 25, 23, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vissza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Összeg:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(324, 170);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(183, 29);
            this.numericUpDown1.TabIndex = 5;
            // 
            // dataGridView_Tagok
            // 
            this.dataGridView_Tagok.AllowUserToAddRows = false;
            this.dataGridView_Tagok.AllowUserToDeleteRows = false;
            this.dataGridView_Tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tagok.Location = new System.Drawing.Point(29, 295);
            this.dataGridView_Tagok.Name = "dataGridView_Tagok";
            this.dataGridView_Tagok.ReadOnly = true;
            this.dataGridView_Tagok.Size = new System.Drawing.Size(672, 256);
            this.dataGridView_Tagok.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Befizetés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teljes név:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(324, 63);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(183, 29);
            this.textBox_nev.TabIndex = 9;
            // 
            // TagBefizetesFelvetele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_Tagok);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TagBefizetesFelvetele";
            this.Text = "TagBefizetesFelvetele";
            this.Load += new System.EventHandler(this.TagBefizetesFelvetele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView_Tagok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nev;
    }
}