namespace BaiTapBuoi6
{
    partial class FrmCalculate
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblIntegrate = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(113, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(372, 22);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(113, 61);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(372, 22);
            this.txtB.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(564, 41);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 42);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Tính";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hiệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tích";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thương";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(564, 257);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(157, 145);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 16);
            this.lblSum.TabIndex = 10;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Location = new System.Drawing.Point(157, 186);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(0, 16);
            this.lblMinus.TabIndex = 11;
            // 
            // lblIntegrate
            // 
            this.lblIntegrate.AutoSize = true;
            this.lblIntegrate.Location = new System.Drawing.Point(157, 234);
            this.lblIntegrate.Name = "lblIntegrate";
            this.lblIntegrate.Size = new System.Drawing.Size(0, 16);
            this.lblIntegrate.TabIndex = 12;
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.Location = new System.Drawing.Point(157, 283);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(0, 16);
            this.lblDivide.TabIndex = 13;
            // 
            // BaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblIntegrate);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaiTap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblIntegrate;
        private System.Windows.Forms.Label lblDivide;
    }
}

