namespace tp4_parte_2
{
    partial class Form2
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
            this.maylist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtrech = new System.Windows.Forms.TextBox();
            this.labres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maylist
            // 
            this.maylist.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maylist.FormattingEnabled = true;
            this.maylist.ItemHeight = 17;
            this.maylist.Items.AddRange(new object[] {
            "Comoros",
            "Congo",
            "Congo(Democratic Rep)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republuc",
            "Denmark",
            "Djibouti",
            "Dpminican Republic",
            "East Timo",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji"});
            this.maylist.Location = new System.Drawing.Point(21, 12);
            this.maylist.Name = "maylist";
            this.maylist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.maylist.Size = new System.Drawing.Size(369, 327);
            this.maylist.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtrech
            // 
            this.txtrech.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrech.Location = new System.Drawing.Point(34, 374);
            this.txtrech.Multiline = true;
            this.txtrech.Name = "txtrech";
            this.txtrech.Size = new System.Drawing.Size(272, 39);
            this.txtrech.TabIndex = 2;
            this.txtrech.TextChanged += new System.EventHandler(this.txtrech_TextChanged);
            // 
            // labres
            // 
            this.labres.AutoSize = true;
            this.labres.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labres.Location = new System.Drawing.Point(18, 424);
            this.labres.Name = "labres";
            this.labres.Size = new System.Drawing.Size(0, 18);
            this.labres.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 446);
            this.Controls.Add(this.labres);
            this.Controls.Add(this.txtrech);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maylist);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox maylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtrech;
        private System.Windows.Forms.Label labres;
    }
}