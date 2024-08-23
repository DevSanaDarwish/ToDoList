namespace ToDoList
{
    partial class frmCalculatePercentage
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
            this.RadialGauge = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExactPercentage = new System.Windows.Forms.Label();
            this.cbOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose:";
            // 
            // RadialGauge
            // 
            this.RadialGauge.ArrowColor = System.Drawing.Color.Purple;
            this.RadialGauge.ArrowThickness = 5;
            this.RadialGauge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RadialGauge.FillColor = System.Drawing.Color.White;
            this.RadialGauge.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadialGauge.ForeColor = System.Drawing.Color.Black;
            this.RadialGauge.Location = new System.Drawing.Point(408, 24);
            this.RadialGauge.MinimumSize = new System.Drawing.Size(30, 30);
            this.RadialGauge.Name = "RadialGauge";
            this.RadialGauge.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.RadialGauge.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RadialGauge.Size = new System.Drawing.Size(414, 414);
            this.RadialGauge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(34, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "The exact percentage is:";
            // 
            // lblExactPercentage
            // 
            this.lblExactPercentage.AutoSize = true;
            this.lblExactPercentage.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExactPercentage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblExactPercentage.Location = new System.Drawing.Point(142, 369);
            this.lblExactPercentage.Name = "lblExactPercentage";
            this.lblExactPercentage.Size = new System.Drawing.Size(99, 45);
            this.lblExactPercentage.TabIndex = 10;
            this.lblExactPercentage.Text = "0 %";
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOptions.ForeColor = System.Drawing.Color.Black;
            this.cbOptions.ItemHeight = 30;
            this.cbOptions.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month"});
            this.cbOptions.Location = new System.Drawing.Point(31, 98);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(260, 36);
            this.cbOptions.TabIndex = 11;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // frmCalculatePercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.lblExactPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadialGauge);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCalculatePercentage";
            this.Text = "Calculate Percentage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadialGauge RadialGauge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExactPercentage;
        private Guna.UI2.WinForms.Guna2ComboBox cbOptions;
    }
}