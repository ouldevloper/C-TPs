namespace tp4_exe_9
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
            this.mylist = new System.Windows.Forms.ListBox();
            this.res = new System.Windows.Forms.Label();
            this.textr = new System.Windows.Forms.TextBox();
            this.recherch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mylist
            // 
            this.mylist.FormattingEnabled = true;
            this.mylist.Items.AddRange(new object[] {
            "Comoros",
            "Congo(Democtratic Rep)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominica Republic",
            "East timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritirea",
            "Estonia",
            "Ethiopia",
            "Fiji"});
            this.mylist.Location = new System.Drawing.Point(32, 12);
            this.mylist.Name = "mylist";
            this.mylist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.mylist.Size = new System.Drawing.Size(228, 277);
            this.mylist.TabIndex = 0;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(29, 346);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(35, 13);
            this.res.TabIndex = 1;
            this.res.Text = "label1";
            // 
            // textr
            // 
            this.textr.Location = new System.Drawing.Point(32, 309);
            this.textr.Name = "textr";
            this.textr.Size = new System.Drawing.Size(154, 20);
            this.textr.TabIndex = 2;
            this.textr.TextChanged += new System.EventHandler(this.textr_TextChanged);
            // 
            // recherch
            // 
            this.recherch.Location = new System.Drawing.Point(192, 306);
            this.recherch.Name = "recherch";
            this.recherch.Size = new System.Drawing.Size(68, 23);
            this.recherch.TabIndex = 3;
            this.recherch.Text = "recherche";
            this.recherch.UseVisualStyleBackColor = true;
            this.recherch.Click += new System.EventHandler(this.recherch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 375);
            this.Controls.Add(this.recherch);
            this.Controls.Add(this.textr);
            this.Controls.Add(this.res);
            this.Controls.Add(this.mylist);
            this.Name = "Form1";
            this.Text = "Recherch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mylist;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.TextBox textr;
        private System.Windows.Forms.Button recherch;
    }
}

