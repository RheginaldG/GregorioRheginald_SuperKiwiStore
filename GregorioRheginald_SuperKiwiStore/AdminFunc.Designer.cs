namespace GregorioRheginald_SuperKiwiStore
{
    partial class AdminFunc
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnInvMan = new System.Windows.Forms.Button();
            this.btnActCrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(52, 26);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 75);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnInvMan
            // 
            this.btnInvMan.Location = new System.Drawing.Point(52, 132);
            this.btnInvMan.Name = "btnInvMan";
            this.btnInvMan.Size = new System.Drawing.Size(148, 75);
            this.btnInvMan.TabIndex = 1;
            this.btnInvMan.Text = "Inventory Management";
            this.btnInvMan.UseVisualStyleBackColor = true;
            this.btnInvMan.Click += new System.EventHandler(this.btnInvMan_Click);
            // 
            // btnActCrt
            // 
            this.btnActCrt.Location = new System.Drawing.Point(52, 240);
            this.btnActCrt.Name = "btnActCrt";
            this.btnActCrt.Size = new System.Drawing.Size(148, 75);
            this.btnActCrt.TabIndex = 2;
            this.btnActCrt.Text = "Account Creation";
            this.btnActCrt.UseVisualStyleBackColor = true;
            this.btnActCrt.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 348);
            this.Controls.Add(this.btnActCrt);
            this.Controls.Add(this.btnInvMan);
            this.Controls.Add(this.btnCheckout);
            this.Name = "AdminFunc";
            this.Text = "Admin Function";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminFunc_FormClosed);
            this.Load += new System.EventHandler(this.AdminFunc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnInvMan;
        private System.Windows.Forms.Button btnActCrt;
    }
}