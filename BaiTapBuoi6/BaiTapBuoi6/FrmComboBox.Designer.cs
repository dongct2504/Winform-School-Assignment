namespace BaiTapBuoi6
{
    partial class FrmComboBox
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
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCity
            // 
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Nam Định",
            "Cà Mau",
            "Lạng Sơn",
            "Lào Cai",
            "Cần Thơ"});
            this.cbbCity.Location = new System.Drawing.Point(147, 102);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(270, 24);
            this.cbbCity.TabIndex = 0;
            this.cbbCity.SelectedIndexChanged += new System.EventHandler(this.cbbCity_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbbCity);
            this.Name = "FrmComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.Button btnExit;
    }
}