namespace tp3_exe_2
{
    partial class dia
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
            this.Afficher = new System.Windows.Forms.CheckBox();
            this.Quiter = new System.Windows.Forms.Button();
            this.Coleurs = new System.Windows.Forms.GroupBox();
            this.Rouge = new System.Windows.Forms.RadioButton();
            this.vert = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Coleurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Afficher
            // 
            this.Afficher.AutoSize = true;
            this.Afficher.Location = new System.Drawing.Point(30, 13);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(115, 17);
            this.Afficher.TabIndex = 0;
            this.Afficher.Text = "Afficher les coleurs";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.CheckedChanged += new System.EventHandler(this.Afficher_CheckedChanged);
            // 
            // Quiter
            // 
            this.Quiter.Location = new System.Drawing.Point(180, 7);
            this.Quiter.Name = "Quiter";
            this.Quiter.Size = new System.Drawing.Size(75, 23);
            this.Quiter.TabIndex = 1;
            this.Quiter.Text = "Quiter";
            this.Quiter.UseVisualStyleBackColor = true;
            this.Quiter.Click += new System.EventHandler(this.Quiter_Click);
            // 
            // Coleurs
            // 
            this.Coleurs.Controls.Add(this.Blue);
            this.Coleurs.Controls.Add(this.vert);
            this.Coleurs.Controls.Add(this.Rouge);
            this.Coleurs.Location = new System.Drawing.Point(12, 90);
            this.Coleurs.Name = "Coleurs";
            this.Coleurs.Size = new System.Drawing.Size(268, 79);
            this.Coleurs.TabIndex = 2;
            this.Coleurs.TabStop = false;
            this.Coleurs.Text = "Coleurs";
            this.Coleurs.Visible = false;
            // 
            // Rouge
            // 
            this.Rouge.AutoSize = true;
            this.Rouge.Location = new System.Drawing.Point(18, 34);
            this.Rouge.Name = "Rouge";
            this.Rouge.Size = new System.Drawing.Size(57, 17);
            this.Rouge.TabIndex = 0;
            this.Rouge.TabStop = true;
            this.Rouge.Text = "Rouge";
            this.Rouge.UseVisualStyleBackColor = true;
            this.Rouge.CheckedChanged += new System.EventHandler(this.Rouge_CheckedChanged);
            // 
            // vert
            // 
            this.vert.AutoSize = true;
            this.vert.Location = new System.Drawing.Point(106, 34);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(43, 17);
            this.vert.TabIndex = 1;
            this.vert.TabStop = true;
            this.vert.Text = "vert";
            this.vert.UseVisualStyleBackColor = true;
            this.vert.CheckedChanged += new System.EventHandler(this.vert_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(197, 34);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 53);
            this.Controls.Add(this.Coleurs);
            this.Controls.Add(this.Quiter);
            this.Controls.Add(this.Afficher);
            this.Name = "dia";
            this.Text = "case a coche 2";
            this.Coleurs.ResumeLayout(false);
            this.Coleurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Afficher;
        private System.Windows.Forms.Button Quiter;
        private System.Windows.Forms.GroupBox Coleurs;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton vert;
        private System.Windows.Forms.RadioButton Rouge;
    }
}

