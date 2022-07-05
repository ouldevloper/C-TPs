namespace tp_5_exe_1
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
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.mylist = new System.Windows.Forms.ListBox();
            this.lcheck = new System.Windows.Forms.CheckedListBox();
            this.com = new System.Windows.Forms.ComboBox();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.lres = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.Mois = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(21, 13);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(67, 16);
            this.l1.TabIndex = 0;
            this.l1.Text = "ListBox";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(148, 12);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(102, 16);
            this.l2.TabIndex = 1;
            this.l2.Text = "CheckedLisBox";
            this.l2.Click += new System.EventHandler(this.l2_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(301, 13);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(83, 17);
            this.l3.TabIndex = 2;
            this.l3.Text = "ComboBox";
            // 
            // mylist
            // 
            this.mylist.FormattingEnabled = true;
            this.mylist.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril"});
            this.mylist.Location = new System.Drawing.Point(12, 48);
            this.mylist.Name = "mylist";
            this.mylist.Size = new System.Drawing.Size(95, 95);
            this.mylist.TabIndex = 3;
            this.mylist.SelectedIndexChanged += new System.EventHandler(this.mylist_SelectedIndexChanged);
            // 
            // lcheck
            // 
            this.lcheck.CheckOnClick = true;
            this.lcheck.FormattingEnabled = true;
            this.lcheck.Items.AddRange(new object[] {
            "Mai",
            "Juin",
            "Jeillet",
            "Aout"});
            this.lcheck.Location = new System.Drawing.Point(151, 48);
            this.lcheck.Name = "lcheck";
            this.lcheck.Size = new System.Drawing.Size(112, 94);
            this.lcheck.TabIndex = 4;
            this.lcheck.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lcheck_ItemCheck);
            this.lcheck.SelectedIndexChanged += new System.EventHandler(this.lcheck_SelectedIndexChanged);
            // 
            // com
            // 
            this.com.FormattingEnabled = true;
            this.com.Items.AddRange(new object[] {
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.com.Location = new System.Drawing.Point(289, 48);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(121, 21);
            this.com.TabIndex = 5;
            this.com.SelectedIndexChanged += new System.EventHandler(this.com_SelectedIndexChanged);
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(12, 170);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(100, 17);
            this.ch1.TabIndex = 6;
            this.ch1.Text = "selection miltupl";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.CheckedChanged += new System.EventHandler(this.ch1_CheckedChanged);
            // 
            // lres
            // 
            this.lres.AutoSize = true;
            this.lres.Location = new System.Drawing.Point(151, 170);
            this.lres.Name = "lres";
            this.lres.Size = new System.Drawing.Size(0, 13);
            this.lres.TabIndex = 7;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(289, 89);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(91, 13);
            this.l4.TabIndex = 8;
            this.l4.Text = "Mois Selectionner";
            // 
            // Mois
            // 
            this.Mois.FormattingEnabled = true;
            this.Mois.Location = new System.Drawing.Point(289, 114);
            this.Mois.Name = "Mois";
            this.Mois.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Mois.Size = new System.Drawing.Size(120, 108);
            this.Mois.TabIndex = 9;
            this.Mois.SelectedIndexChanged += new System.EventHandler(this.Mois_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.Mois);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.lres);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.com);
            this.Controls.Add(this.lcheck);
            this.Controls.Add(this.mylist);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.ListBox mylist;
        private System.Windows.Forms.CheckedListBox lcheck;
        private System.Windows.Forms.ComboBox com;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.Label lres;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.ListBox Mois;
    }
}

