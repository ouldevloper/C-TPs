namespace tp3_2exe
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
            this.colorGB = new System.Windows.Forms.GroupBox();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.black = new System.Windows.Forms.RadioButton();
            this.colorCB = new System.Windows.Forms.CheckBox();
            this.quit = new System.Windows.Forms.Button();
            this.colorGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGB
            // 
            this.colorGB.Controls.Add(this.green);
            this.colorGB.Controls.Add(this.blue);
            this.colorGB.Controls.Add(this.black);
            this.colorGB.Location = new System.Drawing.Point(12, 77);
            this.colorGB.Name = "colorGB";
            this.colorGB.Size = new System.Drawing.Size(315, 52);
            this.colorGB.TabIndex = 1;
            this.colorGB.TabStop = false;
            this.colorGB.Text = "Coulours";
            this.colorGB.Visible = false;
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(209, 18);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(54, 17);
            this.green.TabIndex = 2;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(114, 19);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(46, 17);
            this.blue.TabIndex = 1;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(23, 19);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(52, 17);
            this.black.TabIndex = 0;
            this.black.TabStop = true;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            this.black.CheckedChanged += new System.EventHandler(this.black_CheckedChanged);
            // 
            // colorCB
            // 
            this.colorCB.AutoSize = true;
            this.colorCB.Location = new System.Drawing.Point(69, 34);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(108, 17);
            this.colorCB.TabIndex = 2;
            this.colorCB.Text = "Affiche les Colour";
            this.colorCB.UseVisualStyleBackColor = true;
            this.colorCB.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(221, 28);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 3;
            this.quit.Text = "QUITTEZ";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 215);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.colorCB);
            this.Controls.Add(this.colorGB);
            this.Name = "Form1";
            this.Text = "c";
            this.colorGB.ResumeLayout(false);
            this.colorGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGB;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.CheckBox colorCB;
        private System.Windows.Forms.Button quit;
    }
}

