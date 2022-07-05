namespace tp_6_exe_1
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
            this.l1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.nup2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nper = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(40, 13);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(38, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Intitule";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(145, 10);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(417, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt1.Leave += new System.EventHandler(this.txt1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dd);
            this.groupBox1.Controls.Add(this.d2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.d1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depart";
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(53, 41);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(200, 20);
            this.d1.TabIndex = 4;
            this.d1.ValueChanged += new System.EventHandler(this.d1_ValueChanged);
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(315, 41);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(200, 20);
            this.d2.TabIndex = 6;
            this.d2.ValueChanged += new System.EventHandler(this.d2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arriver";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(536, 47);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(0, 13);
            this.dd.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nper);
            this.groupBox2.Controls.Add(this.nup2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nup1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effectif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de place";
            // 
            // nup1
            // 
            this.nup1.Location = new System.Drawing.Point(102, 53);
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(120, 20);
            this.nup1.TabIndex = 9;
            this.nup1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nup2
            // 
            this.nup2.Location = new System.Drawing.Point(343, 53);
            this.nup2.Name = "nup2";
            this.nup2.Size = new System.Drawing.Size(120, 20);
            this.nup2.TabIndex = 11;
            this.nup2.ValueChanged += new System.EventHandler(this.nup2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "nombre inscrits";
            // 
            // nper
            // 
            this.nper.AutoSize = true;
            this.nper.Location = new System.Drawing.Point(511, 55);
            this.nper.Name = "nper";
            this.nper.Size = new System.Drawing.Size(0, 13);
            this.nper.TabIndex = 12;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(246, 308);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler ";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(400, 308);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // lv
            // 
            this.lv.CheckBoxes = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 359);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(596, 158);
            this.lv.TabIndex = 6;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Intitulé";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Départ";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Arriver";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre de place";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nombre d\'inscrits";
            this.columnHeader5.Width = 132;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 529);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.l1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nper;
        private System.Windows.Forms.NumericUpDown nup2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nup1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

