namespace tp_4_exe_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Label();
            this.AZ = new System.Windows.Forms.Button();
            this.ZA = new System.Windows.Forms.Button();
            this.AZ1 = new System.Windows.Forms.Button();
            this.ZA1 = new System.Windows.Forms.Button();
            this.addtolist = new System.Windows.Forms.Button();
            this.removefromlist = new System.Windows.Forms.Button();
            this.addalltolist = new System.Windows.Forms.Button();
            this.removetolist = new System.Windows.Forms.Button();
            this.atoz = new System.Windows.Forms.Button();
            this.ztoa = new System.Windows.Forms.Button();
            this.atoz1 = new System.Windows.Forms.Button();
            this.ztoa1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Items.AddRange(new object[] {
            "Mousse",
            "Printer",
            "projuctor",
            "Scanner",
            "Speakers",
            "USB thumb drive",
            "CPU",
            "Drive",
            "Modem",
            "Motherboard",
            "Neywork card",
            "ARM",
            "Sound car",
            "Video card",
            "Monitor",
            "Flat-Panel",
            "Keyboard",
            "Microphone"});
            this.list1.Location = new System.Drawing.Point(12, 4);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(120, 196);
            this.list1.TabIndex = 0;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // list2
            // 
            this.list2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(246, 4);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(120, 199);
            this.list2.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Image = global::tp_4_exe_2.Properties.Resources.add;
            this.Add.Location = new System.Drawing.Point(169, 29);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(0, 20);
            this.Add.TabIndex = 2;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AZ
            // 
            this.AZ.Location = new System.Drawing.Point(12, 238);
            this.AZ.Name = "AZ";
            this.AZ.Size = new System.Drawing.Size(49, 23);
            this.AZ.TabIndex = 5;
            this.AZ.Text = "A-Z";
            this.AZ.UseVisualStyleBackColor = true;
            this.AZ.Click += new System.EventHandler(this.AZ_Click);
            // 
            // ZA
            // 
            this.ZA.Location = new System.Drawing.Point(83, 238);
            this.ZA.Name = "ZA";
            this.ZA.Size = new System.Drawing.Size(49, 23);
            this.ZA.TabIndex = 7;
            this.ZA.Text = "Z-A";
            this.ZA.UseVisualStyleBackColor = true;
            this.ZA.Click += new System.EventHandler(this.ZA_Click);
            // 
            // AZ1
            // 
            this.AZ1.Location = new System.Drawing.Point(246, 238);
            this.AZ1.Name = "AZ1";
            this.AZ1.Size = new System.Drawing.Size(49, 23);
            this.AZ1.TabIndex = 8;
            this.AZ1.Text = "A-Z";
            this.AZ1.UseVisualStyleBackColor = true;
            this.AZ1.Click += new System.EventHandler(this.AZ1_Click);
            // 
            // ZA1
            // 
            this.ZA1.Location = new System.Drawing.Point(317, 238);
            this.ZA1.Name = "ZA1";
            this.ZA1.Size = new System.Drawing.Size(49, 23);
            this.ZA1.TabIndex = 9;
            this.ZA1.Text = "Z-A";
            this.ZA1.UseVisualStyleBackColor = true;
            // 
            // addtolist
            // 
            this.addtolist.Image = ((System.Drawing.Image)(resources.GetObject("addtolist.Image")));
            this.addtolist.Location = new System.Drawing.Point(172, 29);
            this.addtolist.Name = "addtolist";
            this.addtolist.Size = new System.Drawing.Size(36, 20);
            this.addtolist.TabIndex = 11;
            this.addtolist.UseVisualStyleBackColor = true;
            this.addtolist.Click += new System.EventHandler(this.addtolist_Click);
            // 
            // removefromlist
            // 
            this.removefromlist.Image = ((System.Drawing.Image)(resources.GetObject("removefromlist.Image")));
            this.removefromlist.Location = new System.Drawing.Point(172, 77);
            this.removefromlist.Name = "removefromlist";
            this.removefromlist.Size = new System.Drawing.Size(36, 23);
            this.removefromlist.TabIndex = 12;
            this.removefromlist.UseVisualStyleBackColor = true;
            this.removefromlist.Click += new System.EventHandler(this.removefromlist_Click);
            // 
            // addalltolist
            // 
            this.addalltolist.Image = ((System.Drawing.Image)(resources.GetObject("addalltolist.Image")));
            this.addalltolist.Location = new System.Drawing.Point(172, 124);
            this.addalltolist.Name = "addalltolist";
            this.addalltolist.Size = new System.Drawing.Size(36, 23);
            this.addalltolist.TabIndex = 13;
            this.addalltolist.UseVisualStyleBackColor = true;
            this.addalltolist.Click += new System.EventHandler(this.addalltolist_Click);
            // 
            // removetolist
            // 
            this.removetolist.Image = ((System.Drawing.Image)(resources.GetObject("removetolist.Image")));
            this.removetolist.Location = new System.Drawing.Point(172, 171);
            this.removetolist.Name = "removetolist";
            this.removetolist.Size = new System.Drawing.Size(36, 23);
            this.removetolist.TabIndex = 14;
            this.removetolist.UseVisualStyleBackColor = true;
            this.removetolist.Click += new System.EventHandler(this.removetolist_Click);
            // 
            // atoz
            // 
            this.atoz.Image = ((System.Drawing.Image)(resources.GetObject("atoz.Image")));
            this.atoz.Location = new System.Drawing.Point(12, 209);
            this.atoz.Name = "atoz";
            this.atoz.Size = new System.Drawing.Size(49, 23);
            this.atoz.TabIndex = 15;
            this.atoz.UseVisualStyleBackColor = true;
            this.atoz.Click += new System.EventHandler(this.atoz_Click);
            // 
            // ztoa
            // 
            this.ztoa.Image = ((System.Drawing.Image)(resources.GetObject("ztoa.Image")));
            this.ztoa.Location = new System.Drawing.Point(83, 209);
            this.ztoa.Name = "ztoa";
            this.ztoa.Size = new System.Drawing.Size(49, 23);
            this.ztoa.TabIndex = 16;
            this.ztoa.UseVisualStyleBackColor = true;
            this.ztoa.Click += new System.EventHandler(this.ztoa_Click);
            // 
            // atoz1
            // 
            this.atoz1.Image = ((System.Drawing.Image)(resources.GetObject("atoz1.Image")));
            this.atoz1.Location = new System.Drawing.Point(246, 209);
            this.atoz1.Name = "atoz1";
            this.atoz1.Size = new System.Drawing.Size(49, 23);
            this.atoz1.TabIndex = 17;
            this.atoz1.UseVisualStyleBackColor = true;
            this.atoz1.Click += new System.EventHandler(this.atoz1_Click);
            // 
            // ztoa1
            // 
            this.ztoa1.Image = ((System.Drawing.Image)(resources.GetObject("ztoa1.Image")));
            this.ztoa1.Location = new System.Drawing.Point(317, 209);
            this.ztoa1.Name = "ztoa1";
            this.ztoa1.Size = new System.Drawing.Size(49, 23);
            this.ztoa1.TabIndex = 18;
            this.ztoa1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(390, 273);
            this.Controls.Add(this.ztoa1);
            this.Controls.Add(this.atoz1);
            this.Controls.Add(this.ztoa);
            this.Controls.Add(this.atoz);
            this.Controls.Add(this.removetolist);
            this.Controls.Add(this.addalltolist);
            this.Controls.Add(this.removefromlist);
            this.Controls.Add(this.addtolist);
            this.Controls.Add(this.ZA1);
            this.Controls.Add(this.AZ1);
            this.Controls.Add(this.ZA);
            this.Controls.Add(this.AZ);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Name = "Form1";
            this.Text = "Manipulation d\'une liste\\trie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Button AZ;
        private System.Windows.Forms.Button ZA;
        private System.Windows.Forms.Button AZ1;
        private System.Windows.Forms.Button ZA1;
        private System.Windows.Forms.Button addtolist;
        private System.Windows.Forms.Button removefromlist;
        private System.Windows.Forms.Button addalltolist;
        private System.Windows.Forms.Button removetolist;
        private System.Windows.Forms.Button atoz;
        private System.Windows.Forms.Button ztoa;
        private System.Windows.Forms.Button atoz1;
        private System.Windows.Forms.Button ztoa1;
    }
}

