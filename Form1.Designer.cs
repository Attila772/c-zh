namespace csharpzh2
{
    partial class Form1
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
            this.Nr = new System.Windows.Forms.TextBox();
            this.Pilota = new System.Windows.Forms.TextBox();
            this.Istallo = new System.Windows.Forms.TextBox();
            this.Futam = new System.Windows.Forms.TextBox();
            this.Pont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pushDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteLBL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Nr_change = new System.Windows.Forms.TextBox();
            this.futam_change = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.changeBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pontszam_change = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lekerd_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lekerdez = new System.Windows.Forms.Button();
            this.personalDG = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Nr
            // 
            this.Nr.Location = new System.Drawing.Point(23, 40);
            this.Nr.Name = "Nr";
            this.Nr.Size = new System.Drawing.Size(100, 22);
            this.Nr.TabIndex = 0;
            // 
            // Pilota
            // 
            this.Pilota.Location = new System.Drawing.Point(129, 40);
            this.Pilota.Name = "Pilota";
            this.Pilota.Size = new System.Drawing.Size(100, 22);
            this.Pilota.TabIndex = 1;
            // 
            // Istallo
            // 
            this.Istallo.Location = new System.Drawing.Point(235, 40);
            this.Istallo.Name = "Istallo";
            this.Istallo.Size = new System.Drawing.Size(100, 22);
            this.Istallo.TabIndex = 2;
            // 
            // Futam
            // 
            this.Futam.Location = new System.Drawing.Point(341, 40);
            this.Futam.Name = "Futam";
            this.Futam.Size = new System.Drawing.Size(100, 22);
            this.Futam.TabIndex = 3;
            // 
            // Pont
            // 
            this.Pont.Location = new System.Drawing.Point(447, 40);
            this.Pont.Name = "Pont";
            this.Pont.Size = new System.Drawing.Size(100, 22);
            this.Pont.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pont";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Futam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Istallo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pilota";
            // 
            // pushDB
            // 
            this.pushDB.Location = new System.Drawing.Point(553, 20);
            this.pushDB.Name = "pushDB";
            this.pushDB.Size = new System.Drawing.Size(117, 52);
            this.pushDB.TabIndex = 10;
            this.pushDB.Text = "Add";
            this.pushDB.UseVisualStyleBackColor = true;
            this.pushDB.Click += new System.EventHandler(this.pushDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // deleteLBL
            // 
            this.deleteLBL.Location = new System.Drawing.Point(38, 287);
            this.deleteLBL.Name = "deleteLBL";
            this.deleteLBL.Size = new System.Drawing.Size(100, 22);
            this.deleteLBL.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delete by NR";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(145, 285);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Nr_change
            // 
            this.Nr_change.Location = new System.Drawing.Point(38, 356);
            this.Nr_change.Name = "Nr_change";
            this.Nr_change.Size = new System.Drawing.Size(100, 22);
            this.Nr_change.TabIndex = 15;
            // 
            // futam_change
            // 
            this.futam_change.Location = new System.Drawing.Point(154, 356);
            this.futam_change.Name = "futam_change";
            this.futam_change.Size = new System.Drawing.Size(100, 22);
            this.futam_change.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Futam";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nr";
            // 
            // changeBTN
            // 
            this.changeBTN.Location = new System.Drawing.Point(154, 396);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(100, 43);
            this.changeBTN.TabIndex = 19;
            this.changeBTN.Text = "Változtat";
            this.changeBTN.UseVisualStyleBackColor = true;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pontszam";
            // 
            // pontszam_change
            // 
            this.pontszam_change.Location = new System.Drawing.Point(41, 416);
            this.pontszam_change.Name = "pontszam_change";
            this.pontszam_change.Size = new System.Drawing.Size(100, 22);
            this.pontszam_change.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 133);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Változtatás";
            // 
            // lekerd_txt
            // 
            this.lekerd_txt.Location = new System.Drawing.Point(285, 285);
            this.lekerd_txt.Name = "lekerd_txt";
            this.lekerd_txt.Size = new System.Drawing.Size(100, 22);
            this.lekerd_txt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Név";
            // 
            // lekerdez
            // 
            this.lekerdez.Location = new System.Drawing.Point(288, 313);
            this.lekerdez.Name = "lekerdez";
            this.lekerdez.Size = new System.Drawing.Size(75, 23);
            this.lekerdez.TabIndex = 25;
            this.lekerdez.Text = "lekerdez";
            this.lekerdez.UseVisualStyleBackColor = true;
            this.lekerdez.Click += new System.EventHandler(this.lekerdez_Click);
            // 
            // personalDG
            // 
            this.personalDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDG.Location = new System.Drawing.Point(392, 283);
            this.personalDG.Name = "personalDG";
            this.personalDG.RowHeadersWidth = 51;
            this.personalDG.RowTemplate.Height = 24;
            this.personalDG.Size = new System.Drawing.Size(396, 150);
            this.personalDG.TabIndex = 26;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(712, 20);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 52);
            this.exit.TabIndex = 27;
            this.exit.Text = "Info";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.personalDG);
            this.Controls.Add(this.lekerdez);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lekerd_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pontszam_change);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.futam_change);
            this.Controls.Add(this.Nr_change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteLBL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pushDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pont);
            this.Controls.Add(this.Futam);
            this.Controls.Add(this.Istallo);
            this.Controls.Add(this.Pilota);
            this.Controls.Add(this.Nr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nr;
        private System.Windows.Forms.TextBox Pilota;
        private System.Windows.Forms.TextBox Istallo;
        private System.Windows.Forms.TextBox Futam;
        private System.Windows.Forms.TextBox Pont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pushDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox deleteLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Nr_change;
        private System.Windows.Forms.TextBox futam_change;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pontszam_change;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lekerd_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button lekerdez;
        private System.Windows.Forms.DataGridView personalDG;
        private System.Windows.Forms.Button exit;
    }
}

