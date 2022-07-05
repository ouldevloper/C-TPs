namespace tp3ex3
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
            this.lbchoix2 = new System.Windows.Forms.Label();
            this.lbchoix1 = new System.Windows.Forms.Label();
            this.opSelectio = new System.Windows.Forms.Button();
            this.choix2group = new System.Windows.Forms.GroupBox();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.choix1group = new System.Windows.Forms.GroupBox();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.choix2group.SuspendLayout();
            this.choix1group.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbchoix2
            // 
            this.lbchoix2.AutoSize = true;
            this.lbchoix2.Location = new System.Drawing.Point(225, 162);
            this.lbchoix2.MaximumSize = new System.Drawing.Size(250, 30);
            this.lbchoix2.Name = "lbchoix2";
            this.lbchoix2.Size = new System.Drawing.Size(0, 13);
            this.lbchoix2.TabIndex = 11;
            // 
            // lbchoix1
            // 
            this.lbchoix1.AutoSize = true;
            this.lbchoix1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbchoix1.Location = new System.Drawing.Point(51, 162);
            this.lbchoix1.Name = "lbchoix1";
            this.lbchoix1.Size = new System.Drawing.Size(0, 13);
            this.lbchoix1.TabIndex = 10;
            // 
            // opSelectio
            // 
            this.opSelectio.Location = new System.Drawing.Point(54, 206);
            this.opSelectio.Name = "opSelectio";
            this.opSelectio.Size = new System.Drawing.Size(239, 28);
            this.opSelectio.TabIndex = 9;
            this.opSelectio.Text = "Option Selectionnees.........";
            this.opSelectio.UseVisualStyleBackColor = true;
            this.opSelectio.Click += new System.EventHandler(this.opSelectio_Click);
            // 
            // choix2group
            // 
            this.choix2group.Controls.Add(this.opt3);
            this.choix2group.Controls.Add(this.opt2);
            this.choix2group.Controls.Add(this.opt1);
            this.choix2group.Location = new System.Drawing.Point(202, 27);
            this.choix2group.Name = "choix2group";
            this.choix2group.Size = new System.Drawing.Size(129, 98);
            this.choix2group.TabIndex = 8;
            this.choix2group.TabStop = false;
            this.choix2group.Text = "Mon Choix 2";
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(6, 65);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(65, 17);
            this.opt3.TabIndex = 3;
            this.opt3.TabStop = true;
            this.opt3.Text = "Option 3";
            this.opt3.UseVisualStyleBackColor = true;
            this.opt3.CheckedChanged += new System.EventHandler(this.opt3_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(6, 42);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(65, 17);
            this.opt2.TabIndex = 2;
            this.opt2.TabStop = true;
            this.opt2.Text = "Option 2";
            this.opt2.UseVisualStyleBackColor = true;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt2_CheckedChanged);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Checked = true;
            this.opt1.Location = new System.Drawing.Point(6, 19);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(65, 17);
            this.opt1.TabIndex = 1;
            this.opt1.TabStop = true;
            this.opt1.Text = "Option 1";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt1_CheckedChanged);
            // 
            // choix1group
            // 
            this.choix1group.Controls.Add(this.op3);
            this.choix1group.Controls.Add(this.op2);
            this.choix1group.Controls.Add(this.op1);
            this.choix1group.Location = new System.Drawing.Point(30, 27);
            this.choix1group.Name = "choix1group";
            this.choix1group.Size = new System.Drawing.Size(129, 98);
            this.choix1group.TabIndex = 7;
            this.choix1group.TabStop = false;
            this.choix1group.Text = "Mon Choix 1";
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(6, 65);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(65, 17);
            this.op3.TabIndex = 2;
            this.op3.TabStop = true;
            this.op3.Text = "Option 3";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.CheckedChanged += new System.EventHandler(this.op3_CheckedChanged);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(6, 42);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(65, 17);
            this.op2.TabIndex = 1;
            this.op2.TabStop = true;
            this.op2.Text = "Option 2";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.CheckedChanged += new System.EventHandler(this.op2_CheckedChanged);
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(6, 19);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(65, 17);
            this.op1.TabIndex = 0;
            this.op1.TabStop = true;
            this.op1.Text = "Option 1";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.CheckedChanged += new System.EventHandler(this.op1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.lbchoix2);
            this.Controls.Add(this.lbchoix1);
            this.Controls.Add(this.opSelectio);
            this.Controls.Add(this.choix2group);
            this.Controls.Add(this.choix1group);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choix2group.ResumeLayout(false);
            this.choix2group.PerformLayout();
            this.choix1group.ResumeLayout(false);
            this.choix1group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbchoix2;
        private System.Windows.Forms.Label lbchoix1;
        private System.Windows.Forms.Button opSelectio;
        private System.Windows.Forms.GroupBox choix2group;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.GroupBox choix1group;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
    }
}

