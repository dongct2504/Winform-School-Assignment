namespace CayTrieuDongWinformGiuaKy
{
    partial class FrmKhoa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmNumberOfStudent = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.txtCourseId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboCourse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 75);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveCourse);
            this.panel3.Controls.Add(this.btnDeleteCourse);
            this.panel3.Controls.Add(this.btnUpdateCourse);
            this.panel3.Controls.Add(this.btnAddCourse);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 75);
            this.panel3.TabIndex = 2;
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(3, 233);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(649, 268);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmNumberOfStudent);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtClassName);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtClassId);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(658, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 268);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnSaveClass);
            this.panel5.Controls.Add(this.btnUpdateClass);
            this.panel5.Controls.Add(this.btnDeleteClass);
            this.panel5.Controls.Add(this.btnAddClass);
            this.panel5.Location = new System.Drawing.Point(3, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1142, 75);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP THÔNG TIN LỚP HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn khoa:";
            // 
            // cboCourse
            // 
            this.cboCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(124, 28);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(239, 31);
            this.cboCourse.TabIndex = 1;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khoa:";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(528, 28);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(242, 30);
            this.txtCourseId.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(912, 28);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(220, 30);
            this.txtCourseName.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Snow;
            this.btnAddCourse.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(45, 16);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(174, 40);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Thêm";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.Location = new System.Drawing.Point(331, 16);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(174, 40);
            this.btnUpdateCourse.TabIndex = 2;
            this.btnUpdateCourse.Text = "Sửa";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(628, 16);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(174, 40);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "Xóa";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.BackColor = System.Drawing.Color.Snow;
            this.btnSaveCourse.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCourse.Location = new System.Drawing.Point(928, 16);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(174, 40);
            this.btnSaveCourse.TabIndex = 4;
            this.btnSaveCourse.Text = "Lưu";
            this.btnSaveCourse.UseVisualStyleBackColor = false;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.BackColor = System.Drawing.Color.Snow;
            this.btnSaveClass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClass.Location = new System.Drawing.Point(637, 19);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(174, 40);
            this.btnSaveClass.TabIndex = 8;
            this.btnSaveClass.Text = "Lưu";
            this.btnSaveClass.UseVisualStyleBackColor = false;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.Snow;
            this.btnDeleteClass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Location = new System.Drawing.Point(439, 19);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(174, 40);
            this.btnDeleteClass.TabIndex = 7;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateClass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.Location = new System.Drawing.Point(240, 19);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(174, 40);
            this.btnUpdateClass.TabIndex = 6;
            this.btnUpdateClass.Text = "Sửa";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.Snow;
            this.btnAddClass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(45, 19);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(174, 40);
            this.btnAddClass.TabIndex = 5;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassId.Location = new System.Drawing.Point(172, 30);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(239, 30);
            this.txtClassId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã lớp:";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(172, 99);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(239, 30);
            this.txtClassName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sĩ số lớp";
            // 
            // nmNumberOfStudent
            // 
            this.nmNumberOfStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmNumberOfStudent.Location = new System.Drawing.Point(172, 174);
            this.nmNumberOfStudent.Name = "nmNumberOfStudent";
            this.nmNumberOfStudent.Size = new System.Drawing.Size(239, 30);
            this.nmNumberOfStudent.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Snow;
            this.btnExit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(968, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 591);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Lớp và Khoa";
            this.Load += new System.EventHandler(this.FrmKhoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.NumericUpDown nmNumberOfStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
    }
}