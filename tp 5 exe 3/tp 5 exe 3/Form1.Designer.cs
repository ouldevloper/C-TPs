namespace tp_5_exe_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.couleur = new System.Windows.Forms.ComboBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ccouleur = new System.Windows.Forms.ComboBox();
            this.l6 = new System.Windows.Forms.Label();
            this.carticle = new System.Windows.Forms.ComboBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.l8 = new System.Windows.Forms.Label();
            this.mantant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud2);
            this.groupBox1.Controls.Add(this.nud1);
            this.groupBox1.Controls.Add(this.couleur);
            this.groupBox1.Controls.Add(this.Ajouter);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.l4);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un Produit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nud2
            // 
            this.nud2.DecimalPlaces = 3;
            this.nud2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            196608});
            this.nud2.Location = new System.Drawing.Point(151, 142);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(161, 20);
            this.nud2.TabIndex = 11;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(151, 106);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(161, 20);
            this.nud1.TabIndex = 10;
            this.nud1.ValueChanged += new System.EventHandler(this.nud1_ValueChanged);
            // 
            // couleur
            // 
            this.couleur.FormattingEnabled = true;
            this.couleur.Location = new System.Drawing.Point(151, 63);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(161, 21);
            this.couleur.TabIndex = 9;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(360, 80);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 8;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(151, 26);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(161, 20);
            this.txt1.TabIndex = 4;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(25, 144);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(24, 13);
            this.l4.TabIndex = 3;
            this.l4.Text = "Prix";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(25, 108);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(97, 13);
            this.l3.TabIndex = 2;
            this.l3.Text = "Quantete on Stock";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(25, 66);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(43, 13);
            this.l2.TabIndex = 1;
            this.l2.Text = "Couleur";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(25, 29);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(61, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "label Article";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ccouleur);
            this.groupBox2.Controls.Add(this.l6);
            this.groupBox2.Controls.Add(this.carticle);
            this.groupBox2.Controls.Add(this.l5);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "choisir d\'article et couleur";
            // 
            // ccouleur
            // 
            this.ccouleur.FormattingEnabled = true;
            this.ccouleur.Location = new System.Drawing.Point(311, 34);
            this.ccouleur.Name = "ccouleur";
            this.ccouleur.Size = new System.Drawing.Size(161, 21);
            this.ccouleur.TabIndex = 12;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(258, 37);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(43, 13);
            this.l6.TabIndex = 11;
            this.l6.Text = "Couleur";
            // 
            // carticle
            // 
            this.carticle.FormattingEnabled = true;
            this.carticle.Location = new System.Drawing.Point(78, 34);
            this.carticle.Name = "carticle";
            this.carticle.Size = new System.Drawing.Size(161, 21);
            this.carticle.TabIndex = 10;
            this.carticle.SelectedIndexChanged += new System.EventHandler(this.carticle_SelectedIndexChanged);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(25, 37);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(36, 13);
            this.l5.TabIndex = 2;
            this.l5.Text = "Article";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(37, 311);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(47, 13);
            this.l7.TabIndex = 13;
            this.l7.Text = "Quantite";
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(102, 309);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(81, 20);
            this.nud3.TabIndex = 12;
            this.nud3.ValueChanged += new System.EventHandler(this.nud3_ValueChanged);
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(270, 311);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(69, 13);
            this.l8.TabIndex = 14;
            this.l8.Text = "Mantant total";
            this.l8.Click += new System.EventHandler(this.label1_Click);
            // 
            // mantant
            // 
            this.mantant.AutoSize = true;
            this.mantant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantant.Location = new System.Drawing.Point(369, 311);
            this.mantant.Name = "mantant";
            this.mantant.Size = new System.Drawing.Size(82, 13);
            this.mantant.TabIndex = 15;
            this.mantant.Text = "Mantant total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 352);
            this.Controls.Add(this.mantant);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.ComboBox couleur;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ccouleur;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.ComboBox carticle;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label mantant;
    }
}

