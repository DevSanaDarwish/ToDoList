namespace ToDoList
{
    partial class frmWelcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTelegramAccount = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbFaceboolAccount = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelegramAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaceboolAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(77, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organize your work and life";
            // 
            // btnGo
            // 
            this.btnGo.AutoRoundedCorners = true;
            this.btnGo.BorderRadius = 21;
            this.btnGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(491, 456);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(247, 45);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go To Main Screen";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developped By Sana Darwish";
            // 
            // pbTelegramAccount
            // 
            this.pbTelegramAccount.BackColor = System.Drawing.Color.Transparent;
            this.pbTelegramAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTelegramAccount.Image = global::ToDoList.Properties.Resources.R__6_;
            this.pbTelegramAccount.ImageRotate = 0F;
            this.pbTelegramAccount.Location = new System.Drawing.Point(297, 464);
            this.pbTelegramAccount.Name = "pbTelegramAccount";
            this.pbTelegramAccount.Size = new System.Drawing.Size(37, 37);
            this.pbTelegramAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTelegramAccount.TabIndex = 11;
            this.pbTelegramAccount.TabStop = false;
            this.pbTelegramAccount.Click += new System.EventHandler(this.pbTelegramAccount_Click);
            // 
            // pbFaceboolAccount
            // 
            this.pbFaceboolAccount.BackColor = System.Drawing.Color.Transparent;
            this.pbFaceboolAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFaceboolAccount.Image = global::ToDoList.Properties.Resources._6a964b23124f6b87cacb059622e2fec0;
            this.pbFaceboolAccount.ImageRotate = 0F;
            this.pbFaceboolAccount.Location = new System.Drawing.Point(245, 464);
            this.pbFaceboolAccount.Name = "pbFaceboolAccount";
            this.pbFaceboolAccount.Size = new System.Drawing.Size(37, 37);
            this.pbFaceboolAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFaceboolAccount.TabIndex = 12;
            this.pbFaceboolAccount.TabStop = false;
            this.pbFaceboolAccount.Click += new System.EventHandler(this.pbFaceboolAccount_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pbFaceboolAccount);
            this.Controls.Add(this.pbTelegramAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWelcome";
            this.Text = "Welcome To to-do list App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTelegramAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaceboolAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox pbTelegramAccount;
        private Guna.UI2.WinForms.Guna2PictureBox pbFaceboolAccount;
    }
}