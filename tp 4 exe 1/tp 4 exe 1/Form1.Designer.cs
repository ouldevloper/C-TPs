namespace tp_4_exe_1
{
    partial class myform
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
            this.List = new System.Windows.Forms.Label();
            this.Pro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.selectindex = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mylist
            // 
            this.mylist.FormattingEnabled = true;
            this.mylist.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "jun",
            "Julet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Decembre",
            ""});
            this.mylist.Location = new System.Drawing.Point(23, 69);
            this.mylist.Name = "mylist";
            this.mylist.Size = new System.Drawing.Size(120, 134);
            this.mylist.TabIndex = 0;
            this.mylist.SelectedIndexChanged += new System.EventHandler(this.mylist_SelectedIndexChanged);
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(20, 33);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(68, 13);
            this.List.TabIndex = 1;
            this.List.Text = "List des Mois";
            // 
            // Pro
            // 
            this.Pro.AutoSize = true;
            this.Pro.Location = new System.Drawing.Point(210, 33);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(54, 13);
            this.Pro.TabIndex = 2;
            this.Pro.Text = "Proprietes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item.count";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(210, 123);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(63, 13);
            this.Index.TabIndex = 4;
            this.Index.Text = "SelectIndex";
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(210, 169);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(28, 13);
            this.Text.TabIndex = 5;
            this.Text.Text = "Text";
            // 
            // item
            // 
            this.item.Enabled = false;
            this.item.Location = new System.Drawing.Point(273, 84);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(117, 20);
            this.item.TabIndex = 6;
            this.item.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectindex
            // 
            this.selectindex.Enabled = false;
            this.selectindex.Location = new System.Drawing.Point(273, 120);
            this.selectindex.Name = "selectindex";
            this.selectindex.Size = new System.Drawing.Size(117, 20);
            this.selectindex.TabIndex = 7;
            this.selectindex.TextChanged += new System.EventHandler(this.selectindex_TextChanged);
            // 
            // t
            // 
            this.t.Enabled = false;
            this.t.Location = new System.Drawing.Point(273, 162);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(117, 20);
            this.t.TabIndex = 8;
            this.t.TextChanged += new System.EventHandler(this.t_TextChanged);
            // 
            // myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 230);
            this.Controls.Add(this.t);
            this.Controls.Add(this.selectindex);
            this.Controls.Add(this.item);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.List);
            this.Controls.Add(this.mylist);
            this.Name = "myform";
            this.Text = "les listes";
            this.Load += new System.EventHandler(this.myform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mylist;
        private System.Windows.Forms.Label List;
        private System.Windows.Forms.Label Pro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox selectindex;
        private System.Windows.Forms.TextBox t;
    }
}

