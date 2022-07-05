namespace TP_2
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
            this.l4 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.GroupBox();
            this.Racinecarré = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.Multiplication = new System.Windows.Forms.RadioButton();
            this.Soustraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(23, 24);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(61, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Nombre 1";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(23, 65);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(61, 13);
            this.l2.TabIndex = 1;
            this.l2.Text = "Nombre 2";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(23, 116);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(54, 13);
            this.l3.TabIndex = 2;
            this.l3.Text = "Resultat";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(205, 40);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(14, 13);
            this.l4.TabIndex = 3;
            this.l4.Text = "+";
            this.l4.Click += new System.EventHandler(this.l4_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b2.Enabled = false;
            this.b2.Location = new System.Drawing.Point(256, 160);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 37);
            this.b2.TabIndex = 4;
            this.b2.Text = "OK";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(37, 160);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(94, 37);
            this.b1.TabIndex = 5;
            this.b1.Text = "Remise à blanc";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(126, 17);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(178, 20);
            this.t1.TabIndex = 6;
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged);
            this.t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(126, 58);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(178, 20);
            this.t2.TabIndex = 7;
            this.t2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t3
            // 
            this.t3.Enabled = false;
            this.t3.Location = new System.Drawing.Point(126, 109);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(178, 20);
            this.t3.TabIndex = 8;
            // 
            // operation
            // 
            this.operation.Controls.Add(this.Racinecarré);
            this.operation.Controls.Add(this.Division);
            this.operation.Controls.Add(this.Multiplication);
            this.operation.Controls.Add(this.Soustraction);
            this.operation.Controls.Add(this.addition);
            this.operation.Location = new System.Drawing.Point(358, 17);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(145, 180);
            this.operation.TabIndex = 9;
            this.operation.TabStop = false;
            this.operation.Text = "operation";
            this.operation.ClientSizeChanged += new System.EventHandler(this.operation_ClientSizeChanged);
            // 
            // Racinecarré
            // 
            this.Racinecarré.AutoSize = true;
            this.Racinecarré.Location = new System.Drawing.Point(27, 143);
            this.Racinecarré.Name = "Racinecarré";
            this.Racinecarré.Size = new System.Drawing.Size(86, 17);
            this.Racinecarré.TabIndex = 4;
            this.Racinecarré.Text = "Racine carré";
            this.Racinecarré.UseVisualStyleBackColor = true;
            this.Racinecarré.CheckedChanged += new System.EventHandler(this.Racinecarré_CheckedChanged);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(28, 109);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(62, 17);
            this.Division.TabIndex = 3;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.CheckedChanged += new System.EventHandler(this.Division_CheckedChanged);
            // 
            // Multiplication
            // 
            this.Multiplication.AutoSize = true;
            this.Multiplication.Location = new System.Drawing.Point(28, 76);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(86, 17);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.CheckedChanged += new System.EventHandler(this.Multiplication_CheckedChanged);
            // 
            // Soustraction
            // 
            this.Soustraction.AutoSize = true;
            this.Soustraction.Location = new System.Drawing.Point(28, 48);
            this.Soustraction.Name = "Soustraction";
            this.Soustraction.Size = new System.Drawing.Size(84, 17);
            this.Soustraction.TabIndex = 1;
            this.Soustraction.Text = "Soustraction";
            this.Soustraction.UseVisualStyleBackColor = true;
            this.Soustraction.CheckedChanged += new System.EventHandler(this.Soustraction_CheckedChanged);
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Checked = true;
            this.addition.Location = new System.Drawing.Point(28, 23);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(62, 17);
            this.addition.TabIndex = 0;
            this.addition.TabStop = true;
            this.addition.Text = "addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.CheckedChanged += new System.EventHandler(this.addition_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 226);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.operation.ResumeLayout(false);
            this.operation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.GroupBox operation;
        private System.Windows.Forms.RadioButton Racinecarré;
        private System.Windows.Forms.RadioButton Division;
        private System.Windows.Forms.RadioButton Multiplication;
        private System.Windows.Forms.RadioButton Soustraction;
        private System.Windows.Forms.RadioButton addition;
    }
}

