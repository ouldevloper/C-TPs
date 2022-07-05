namespace tp3_exe_3
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
            this.choix1 = new System.Windows.Forms.GroupBox();
            this.Choix2 = new System.Windows.Forms.GroupBox();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.option5 = new System.Windows.Forms.RadioButton();
            this.option6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Button();
            this.choix1.SuspendLayout();
            this.Choix2.SuspendLayout();
            this.SuspendLayout();
            // 
            // choix1
            // 
            this.choix1.Controls.Add(this.option3);
            this.choix1.Controls.Add(this.option2);
            this.choix1.Controls.Add(this.option1);
            this.choix1.Location = new System.Drawing.Point(8, 13);
            this.choix1.Name = "choix1";
            this.choix1.Size = new System.Drawing.Size(145, 150);
            this.choix1.TabIndex = 0;
            this.choix1.TabStop = false;
            this.choix1.Text = "Mon Choix 1";
            this.choix1.Enter += new System.EventHandler(this.choix1_Enter);
            // 
            // Choix2
            // 
            this.Choix2.Controls.Add(this.option6);
            this.Choix2.Controls.Add(this.option5);
            this.Choix2.Controls.Add(this.option4);
            this.Choix2.Location = new System.Drawing.Point(185, 13);
            this.Choix2.Name = "Choix2";
            this.Choix2.Size = new System.Drawing.Size(145, 150);
            this.Choix2.TabIndex = 1;
            this.Choix2.TabStop = false;
            this.Choix2.Text = "Mon Choix 2";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Checked = true;
            this.option1.Location = new System.Drawing.Point(7, 20);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(60, 17);
            this.option1.TabIndex = 0;
            this.option1.TabStop = true;
            this.option1.Tag = "Bouton N°1";
            this.option1.Text = "option1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(6, 61);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(60, 17);
            this.option2.TabIndex = 1;
            this.option2.Tag = "Bouton N°2";
            this.option2.Text = "option2";
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(6, 109);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(60, 17);
            this.option3.TabIndex = 2;
            this.option3.TabStop = true;
            this.option3.Tag = "Bouton N°3";
            this.option3.Text = "option3";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Checked = true;
            this.option4.Location = new System.Drawing.Point(6, 19);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(60, 17);
            this.option4.TabIndex = 0;
            this.option4.TabStop = true;
            this.option4.Tag = "Bouton N°1";
            this.option4.Text = "option1";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // option5
            // 
            this.option5.AutoSize = true;
            this.option5.Location = new System.Drawing.Point(6, 61);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(60, 17);
            this.option5.TabIndex = 1;
            this.option5.TabStop = true;
            this.option5.Tag = "Bouton N°2";
            this.option5.Text = "option2";
            this.option5.UseVisualStyleBackColor = true;
            // 
            // option6
            // 
            this.option6.AutoSize = true;
            this.option6.Location = new System.Drawing.Point(6, 109);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(60, 17);
            this.option6.TabIndex = 2;
            this.option6.TabStop = true;
            this.option6.Tag = "Bouton N°3";
            this.option6.Text = "option3";
            this.option6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(38, 223);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(259, 23);
            this.b.TabIndex = 4;
            this.b.Text = "Option Selectionnee...";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 256);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choix2);
            this.Controls.Add(this.choix1);
            this.Name = "Form1";
            this.Text = "radio bouton";
            this.choix1.ResumeLayout(false);
            this.choix1.PerformLayout();
            this.Choix2.ResumeLayout(false);
            this.Choix2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox choix1;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.GroupBox Choix2;
        private System.Windows.Forms.RadioButton option6;
        private System.Windows.Forms.RadioButton option5;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b;
    }
}

