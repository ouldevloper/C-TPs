namespace tp_5_exe_2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.lstlist = new System.Windows.Forms.ListBox();
            this.l5 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.l7 = new System.Windows.Forms.Label();
            this.btnsup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(23, 13);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(95, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Nouvel element";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(169, 13);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(87, 13);
            this.l2.TabIndex = 1;
            this.l2.Text = "Index Element";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 40);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(136, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(172, 40);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(52, 20);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(245, 37);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Selectionner";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 76);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Ajouter a la list";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(245, 76);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Vider la liste";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(23, 136);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(36, 13);
            this.l3.TabIndex = 7;
            this.l3.Text = "lstlist";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(169, 136);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(64, 13);
            this.l4.TabIndex = 8;
            this.l4.Text = "Proprietes";
            // 
            // lstlist
            // 
            this.lstlist.FormattingEnabled = true;
            this.lstlist.Location = new System.Drawing.Point(12, 166);
            this.lstlist.Name = "lstlist";
            this.lstlist.Size = new System.Drawing.Size(120, 95);
            this.lstlist.TabIndex = 9;
            this.lstlist.SelectedIndexChanged += new System.EventHandler(this.lstlist_SelectedIndexChanged);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(169, 166);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(67, 13);
            this.l5.TabIndex = 10;
            this.l5.Text = "Item count";
            // 
            // txtitem
            // 
            this.txtitem.Enabled = false;
            this.txtitem.Location = new System.Drawing.Point(258, 163);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(52, 20);
            this.txtitem.TabIndex = 11;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            // 
            // t4
            // 
            this.t4.Enabled = false;
            this.t4.Location = new System.Drawing.Point(258, 203);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(52, 20);
            this.t4.TabIndex = 13;
            this.t4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(169, 206);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(88, 13);
            this.l6.TabIndex = 12;
            this.l6.Text = "SelectedIndex";
            // 
            // t5
            // 
            this.t5.Enabled = false;
            this.t5.Location = new System.Drawing.Point(258, 235);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(52, 20);
            this.t5.TabIndex = 15;
            this.t5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(169, 238);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(32, 13);
            this.l7.TabIndex = 14;
            this.l7.Text = "Text";
            // 
            // btnsup
            // 
            this.btnsup.Location = new System.Drawing.Point(199, 261);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(75, 23);
            this.btnsup.TabIndex = 16;
            this.btnsup.Text = "Supprimer";
            this.btnsup.UseVisualStyleBackColor = true;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 291);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.lstlist);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "exercice 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.ListBox lstlist;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Button btnsup;
    }
}

