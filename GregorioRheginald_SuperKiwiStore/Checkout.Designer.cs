namespace GregorioRheginald_SuperKiwiStore
{
    partial class Checkout
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
            this.PcodeLable = new System.Windows.Forms.Label();
            this.Pquntitylable = new System.Windows.Forms.Label();
            this.Iquntity_tBox = new System.Windows.Forms.TextBox();
            this.CO_addbtn = new System.Windows.Forms.Button();
            this.CO_removebtn = new System.Windows.Forms.Button();
            this.Item_input_comb = new System.Windows.Forms.ComboBox();
            this.Salesprodlist = new System.Windows.Forms.DataGridView();
            this.CO_Payconfirmbtn = new System.Windows.Forms.Button();
            this.tpr = new System.Windows.Forms.Label();
            this.Totalprlabel = new System.Windows.Forms.Label();
            this.CO_Closebtn = new System.Windows.Forms.Button();
            this.cmbdisc = new System.Windows.Forms.ComboBox();
            this.lbldiscountstat = new System.Windows.Forms.Label();
            this.lbldiscounttype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Salesprodlist)).BeginInit();
            this.SuspendLayout();
            // 
            // PcodeLable
            // 
            this.PcodeLable.AutoSize = true;
            this.PcodeLable.Location = new System.Drawing.Point(21, 161);
            this.PcodeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PcodeLable.Name = "PcodeLable";
            this.PcodeLable.Size = new System.Drawing.Size(72, 13);
            this.PcodeLable.TabIndex = 0;
            this.PcodeLable.Text = "Product Code";
            // 
            // Pquntitylable
            // 
            this.Pquntitylable.AutoSize = true;
            this.Pquntitylable.Location = new System.Drawing.Point(264, 161);
            this.Pquntitylable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pquntitylable.Name = "Pquntitylable";
            this.Pquntitylable.Size = new System.Drawing.Size(46, 13);
            this.Pquntitylable.TabIndex = 1;
            this.Pquntitylable.Text = "Quantity";
            // 
            // Iquntity_tBox
            // 
            this.Iquntity_tBox.Location = new System.Drawing.Point(314, 158);
            this.Iquntity_tBox.Margin = new System.Windows.Forms.Padding(2);
            this.Iquntity_tBox.Name = "Iquntity_tBox";
            this.Iquntity_tBox.Size = new System.Drawing.Size(102, 20);
            this.Iquntity_tBox.TabIndex = 2;
            // 
            // CO_addbtn
            // 
            this.CO_addbtn.Location = new System.Drawing.Point(905, 158);
            this.CO_addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.CO_addbtn.Name = "CO_addbtn";
            this.CO_addbtn.Size = new System.Drawing.Size(134, 78);
            this.CO_addbtn.TabIndex = 5;
            this.CO_addbtn.Text = "Add";
            this.CO_addbtn.UseVisualStyleBackColor = true;
            this.CO_addbtn.Click += new System.EventHandler(this.CO_addbtn_Click);
            // 
            // CO_removebtn
            // 
            this.CO_removebtn.Location = new System.Drawing.Point(905, 260);
            this.CO_removebtn.Margin = new System.Windows.Forms.Padding(2);
            this.CO_removebtn.Name = "CO_removebtn";
            this.CO_removebtn.Size = new System.Drawing.Size(134, 78);
            this.CO_removebtn.TabIndex = 6;
            this.CO_removebtn.Text = "Remove";
            this.CO_removebtn.UseVisualStyleBackColor = true;
            this.CO_removebtn.Click += new System.EventHandler(this.CO_removebtn_Click);
            // 
            // Item_input_comb
            // 
            this.Item_input_comb.FormattingEnabled = true;
            this.Item_input_comb.Location = new System.Drawing.Point(108, 158);
            this.Item_input_comb.Margin = new System.Windows.Forms.Padding(2);
            this.Item_input_comb.Name = "Item_input_comb";
            this.Item_input_comb.Size = new System.Drawing.Size(126, 21);
            this.Item_input_comb.TabIndex = 7;
            // 
            // Salesprodlist
            // 
            this.Salesprodlist.AllowUserToAddRows = false;
            this.Salesprodlist.AllowUserToDeleteRows = false;
            this.Salesprodlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Salesprodlist.Location = new System.Drawing.Point(18, 184);
            this.Salesprodlist.Name = "Salesprodlist";
            this.Salesprodlist.ReadOnly = true;
            this.Salesprodlist.RowHeadersWidth = 62;
            this.Salesprodlist.Size = new System.Drawing.Size(873, 316);
            this.Salesprodlist.TabIndex = 23;
            // 
            // CO_Payconfirmbtn
            // 
            this.CO_Payconfirmbtn.Location = new System.Drawing.Point(905, 452);
            this.CO_Payconfirmbtn.Margin = new System.Windows.Forms.Padding(2);
            this.CO_Payconfirmbtn.Name = "CO_Payconfirmbtn";
            this.CO_Payconfirmbtn.Size = new System.Drawing.Size(134, 82);
            this.CO_Payconfirmbtn.TabIndex = 24;
            this.CO_Payconfirmbtn.Text = "Payment Confirmed";
            this.CO_Payconfirmbtn.UseVisualStyleBackColor = true;
            this.CO_Payconfirmbtn.Click += new System.EventHandler(this.CO_Payconfirmbtn_Click);
            // 
            // tpr
            // 
            this.tpr.AutoSize = true;
            this.tpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tpr.Location = new System.Drawing.Point(14, 514);
            this.tpr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tpr.Name = "tpr";
            this.tpr.Size = new System.Drawing.Size(109, 20);
            this.tpr.TabIndex = 25;
            this.tpr.Text = "Total Price : ";
            this.tpr.Click += new System.EventHandler(this.label3_Click);
            // 
            // Totalprlabel
            // 
            this.Totalprlabel.AutoSize = true;
            this.Totalprlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Totalprlabel.Location = new System.Drawing.Point(127, 514);
            this.Totalprlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Totalprlabel.Name = "Totalprlabel";
            this.Totalprlabel.Size = new System.Drawing.Size(19, 20);
            this.Totalprlabel.TabIndex = 26;
            this.Totalprlabel.Text = "0";
            this.Totalprlabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CO_Closebtn
            // 
            this.CO_Closebtn.Location = new System.Drawing.Point(905, 359);
            this.CO_Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.CO_Closebtn.Name = "CO_Closebtn";
            this.CO_Closebtn.Size = new System.Drawing.Size(134, 78);
            this.CO_Closebtn.TabIndex = 27;
            this.CO_Closebtn.Text = "Close Checkout";
            this.CO_Closebtn.UseVisualStyleBackColor = true;
            this.CO_Closebtn.Click += new System.EventHandler(this.CO_Closebtn_Click);
            // 
            // cmbdisc
            // 
            this.cmbdisc.FormattingEnabled = true;
            this.cmbdisc.Location = new System.Drawing.Point(18, 68);
            this.cmbdisc.Name = "cmbdisc";
            this.cmbdisc.Size = new System.Drawing.Size(257, 21);
            this.cmbdisc.TabIndex = 28;
            this.cmbdisc.SelectedIndexChanged += new System.EventHandler(this.cmbdisc_SelectedIndexChanged);
            // 
            // lbldiscountstat
            // 
            this.lbldiscountstat.AutoSize = true;
            this.lbldiscountstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldiscountstat.Location = new System.Drawing.Point(20, 102);
            this.lbldiscountstat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiscountstat.Name = "lbldiscountstat";
            this.lbldiscountstat.Size = new System.Drawing.Size(15, 20);
            this.lbldiscountstat.TabIndex = 29;
            this.lbldiscountstat.Text = "-";
            // 
            // lbldiscounttype
            // 
            this.lbldiscounttype.AutoSize = true;
            this.lbldiscounttype.Location = new System.Drawing.Point(18, 49);
            this.lbldiscounttype.Name = "lbldiscounttype";
            this.lbldiscounttype.Size = new System.Drawing.Size(107, 13);
            this.lbldiscounttype.TabIndex = 30;
            this.lbldiscounttype.Text = "Enter Discount Type:";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 624);
            this.Controls.Add(this.lbldiscounttype);
            this.Controls.Add(this.lbldiscountstat);
            this.Controls.Add(this.cmbdisc);
            this.Controls.Add(this.CO_Closebtn);
            this.Controls.Add(this.Totalprlabel);
            this.Controls.Add(this.tpr);
            this.Controls.Add(this.CO_Payconfirmbtn);
            this.Controls.Add(this.Salesprodlist);
            this.Controls.Add(this.Item_input_comb);
            this.Controls.Add(this.CO_removebtn);
            this.Controls.Add(this.CO_addbtn);
            this.Controls.Add(this.Iquntity_tBox);
            this.Controls.Add(this.Pquntitylable);
            this.Controls.Add(this.PcodeLable);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salesprodlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PcodeLable;
        private System.Windows.Forms.Label Pquntitylable;
        private System.Windows.Forms.TextBox Iquntity_tBox;
        private System.Windows.Forms.Button CO_addbtn;
        private System.Windows.Forms.Button CO_removebtn;
        private System.Windows.Forms.ComboBox Item_input_comb;
        private System.Windows.Forms.DataGridView Salesprodlist;
        private System.Windows.Forms.Button CO_Payconfirmbtn;
        private System.Windows.Forms.Label tpr;
        private System.Windows.Forms.Label Totalprlabel;
        private System.Windows.Forms.Button CO_Closebtn;
        private System.Windows.Forms.ComboBox cmbdisc;
        private System.Windows.Forms.Label lbldiscountstat;
        private System.Windows.Forms.Label lbldiscounttype;
    }
}