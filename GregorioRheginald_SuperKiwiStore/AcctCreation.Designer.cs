
namespace GregorioRheginald_SuperKiwiStore
{
    partial class AcctCreation
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
            this.txtusercreate = new System.Windows.Forms.TextBox();
            this.txtpasscreate = new System.Windows.Forms.TextBox();
            this.lbluscreate = new System.Windows.Forms.Label();
            this.lblPassCreate = new System.Windows.Forms.Label();
            this.usercreatedash = new System.Windows.Forms.Label();
            this.PassCreateDash = new System.Windows.Forms.Label();
            this.btnacctcreate = new System.Windows.Forms.Button();
            this.cmbacctcreate = new System.Windows.Forms.ComboBox();
            this.lbltitleacctcreate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusercreate
            // 
            this.txtusercreate.Location = new System.Drawing.Point(48, 74);
            this.txtusercreate.Name = "txtusercreate";
            this.txtusercreate.Size = new System.Drawing.Size(247, 20);
            this.txtusercreate.TabIndex = 0;
            this.txtusercreate.TextChanged += new System.EventHandler(this.txtusercreate_TextChanged);
            // 
            // txtpasscreate
            // 
            this.txtpasscreate.Location = new System.Drawing.Point(48, 160);
            this.txtpasscreate.Name = "txtpasscreate";
            this.txtpasscreate.Size = new System.Drawing.Size(247, 20);
            this.txtpasscreate.TabIndex = 1;
            this.txtpasscreate.TextChanged += new System.EventHandler(this.txtpasscreate_TextChanged);
            // 
            // lbluscreate
            // 
            this.lbluscreate.AutoSize = true;
            this.lbluscreate.Location = new System.Drawing.Point(48, 55);
            this.lbluscreate.Name = "lbluscreate";
            this.lbluscreate.Size = new System.Drawing.Size(58, 13);
            this.lbluscreate.TabIndex = 2;
            this.lbluscreate.Text = "Username:";
            // 
            // lblPassCreate
            // 
            this.lblPassCreate.AutoSize = true;
            this.lblPassCreate.Location = new System.Drawing.Point(48, 141);
            this.lblPassCreate.Name = "lblPassCreate";
            this.lblPassCreate.Size = new System.Drawing.Size(56, 13);
            this.lblPassCreate.TabIndex = 3;
            this.lblPassCreate.Text = "Password:";
            // 
            // usercreatedash
            // 
            this.usercreatedash.AutoSize = true;
            this.usercreatedash.Location = new System.Drawing.Point(48, 101);
            this.usercreatedash.Name = "usercreatedash";
            this.usercreatedash.Size = new System.Drawing.Size(10, 13);
            this.usercreatedash.TabIndex = 4;
            this.usercreatedash.Text = "-";
            // 
            // PassCreateDash
            // 
            this.PassCreateDash.AutoSize = true;
            this.PassCreateDash.Location = new System.Drawing.Point(48, 187);
            this.PassCreateDash.Name = "PassCreateDash";
            this.PassCreateDash.Size = new System.Drawing.Size(10, 13);
            this.PassCreateDash.TabIndex = 5;
            this.PassCreateDash.Text = "-";
            // 
            // btnacctcreate
            // 
            this.btnacctcreate.Location = new System.Drawing.Point(110, 300);
            this.btnacctcreate.Name = "btnacctcreate";
            this.btnacctcreate.Size = new System.Drawing.Size(112, 23);
            this.btnacctcreate.TabIndex = 6;
            this.btnacctcreate.Text = "Create Account";
            this.btnacctcreate.UseVisualStyleBackColor = true;
            this.btnacctcreate.Click += new System.EventHandler(this.btnacctcreate_Click);
            // 
            // cmbacctcreate
            // 
            this.cmbacctcreate.FormattingEnabled = true;
            this.cmbacctcreate.Location = new System.Drawing.Point(48, 223);
            this.cmbacctcreate.Name = "cmbacctcreate";
            this.cmbacctcreate.Size = new System.Drawing.Size(247, 21);
            this.cmbacctcreate.TabIndex = 7;
            // 
            // lbltitleacctcreate
            // 
            this.lbltitleacctcreate.AutoSize = true;
            this.lbltitleacctcreate.Location = new System.Drawing.Point(48, 204);
            this.lbltitleacctcreate.Name = "lbltitleacctcreate";
            this.lbltitleacctcreate.Size = new System.Drawing.Size(30, 13);
            this.lbltitleacctcreate.TabIndex = 8;
            this.lbltitleacctcreate.Text = "Title:";
            this.lbltitleacctcreate.Click += new System.EventHandler(this.label1_Click);
            // 
            // AcctCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.lbltitleacctcreate);
            this.Controls.Add(this.cmbacctcreate);
            this.Controls.Add(this.btnacctcreate);
            this.Controls.Add(this.PassCreateDash);
            this.Controls.Add(this.usercreatedash);
            this.Controls.Add(this.lblPassCreate);
            this.Controls.Add(this.lbluscreate);
            this.Controls.Add(this.txtpasscreate);
            this.Controls.Add(this.txtusercreate);
            this.Name = "AcctCreation";
            this.Text = "AcctCreation";
            this.Load += new System.EventHandler(this.AcctCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusercreate;
        private System.Windows.Forms.TextBox txtpasscreate;
        private System.Windows.Forms.Label lbluscreate;
        private System.Windows.Forms.Label lblPassCreate;
        private System.Windows.Forms.Label usercreatedash;
        private System.Windows.Forms.Label PassCreateDash;
        private System.Windows.Forms.Button btnacctcreate;
        private System.Windows.Forms.ComboBox cmbacctcreate;
        private System.Windows.Forms.Label lbltitleacctcreate;
    }
}