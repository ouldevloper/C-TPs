namespace ex2_tp_6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textnomination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combogeure = new System.Windows.Forms.ComboBox();
            this.labelgeur = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texttitre = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonsmall = new System.Windows.Forms.Button();
            this.buttonlarge = new System.Windows.Forms.Button();
            this.buttondetails = new System.Windows.Forms.Button();
            this.buttonlist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textnomination);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combogeure);
            this.groupBox1.Controls.Add(this.labelgeur);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.texttitre);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information sur le filme";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(489, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "parcourir ...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(489, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 87);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textnomination
            // 
            this.textnomination.Location = new System.Drawing.Point(489, 35);
            this.textnomination.Name = "textnomination";
            this.textnomination.Size = new System.Drawing.Size(120, 25);
            this.textnomination.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nomination";
            // 
            // combogeure
            // 
            this.combogeure.FormattingEnabled = true;
            this.combogeure.Items.AddRange(new object[] {
            "Drame",
            "Action",
            "Historique"});
            this.combogeure.Location = new System.Drawing.Point(94, 127);
            this.combogeure.Name = "combogeure";
            this.combogeure.Size = new System.Drawing.Size(121, 26);
            this.combogeure.TabIndex = 7;
            this.combogeure.SelectedIndexChanged += new System.EventHandler(this.combogeure_SelectedIndexChanged);
            // 
            // labelgeur
            // 
            this.labelgeur.AutoSize = true;
            this.labelgeur.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgeur.Location = new System.Drawing.Point(16, 127);
            this.labelgeur.Name = "labelgeur";
            this.labelgeur.Size = new System.Drawing.Size(44, 18);
            this.labelgeur.TabIndex = 6;
            this.labelgeur.Text = "geure";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(94, 84);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 25);
            this.num1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gains";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titre";
            // 
            // texttitre
            // 
            this.texttitre.Location = new System.Drawing.Point(94, 38);
            this.texttitre.Name = "texttitre";
            this.texttitre.Size = new System.Drawing.Size(120, 25);
            this.texttitre.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(22, 289);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 159);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nomination";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gains";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.imageList1.Images.SetKeyName(1, "Desert.jpg");
            this.imageList1.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.imageList1.Images.SetKeyName(3, "Jellyfish.jpg");
            this.imageList1.Images.SetKeyName(4, "Koala.jpg");
            this.imageList1.Images.SetKeyName(5, "Lighthouse.jpg");
            this.imageList1.Images.SetKeyName(6, "Tulips.jpg");
            // 
            // buttonsmall
            // 
            this.buttonsmall.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsmall.Location = new System.Drawing.Point(698, 301);
            this.buttonsmall.Name = "buttonsmall";
            this.buttonsmall.Size = new System.Drawing.Size(100, 26);
            this.buttonsmall.TabIndex = 13;
            this.buttonsmall.Text = "Small Icon";
            this.buttonsmall.UseVisualStyleBackColor = true;
            this.buttonsmall.Click += new System.EventHandler(this.buttonsmall_Click);
            // 
            // buttonlarge
            // 
            this.buttonlarge.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlarge.Location = new System.Drawing.Point(698, 333);
            this.buttonlarge.Name = "buttonlarge";
            this.buttonlarge.Size = new System.Drawing.Size(100, 26);
            this.buttonlarge.TabIndex = 14;
            this.buttonlarge.Text = "Large Icon";
            this.buttonlarge.UseVisualStyleBackColor = true;
            this.buttonlarge.Click += new System.EventHandler(this.buttonlarge_Click);
            // 
            // buttondetails
            // 
            this.buttondetails.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondetails.Location = new System.Drawing.Point(698, 365);
            this.buttondetails.Name = "buttondetails";
            this.buttondetails.Size = new System.Drawing.Size(100, 26);
            this.buttondetails.TabIndex = 15;
            this.buttondetails.Text = "Details";
            this.buttondetails.UseVisualStyleBackColor = true;
            this.buttondetails.Click += new System.EventHandler(this.buttondetails_Click);
            // 
            // buttonlist
            // 
            this.buttonlist.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlist.Location = new System.Drawing.Point(698, 397);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(100, 26);
            this.buttonlist.TabIndex = 16;
            this.buttonlist.Text = "List";
            this.buttonlist.UseVisualStyleBackColor = true;
            this.buttonlist.Click += new System.EventHandler(this.buttonlist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 460);
            this.Controls.Add(this.buttonlist);
            this.Controls.Add(this.buttondetails);
            this.Controls.Add(this.buttonlarge);
            this.Controls.Add(this.buttonsmall);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textnomination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combogeure;
        private System.Windows.Forms.Label labelgeur;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texttitre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonsmall;
        private System.Windows.Forms.Button buttonlarge;
        private System.Windows.Forms.Button buttondetails;
        private System.Windows.Forms.Button buttonlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

