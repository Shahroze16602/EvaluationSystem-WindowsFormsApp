﻿namespace EvaluationSystem
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSubjPre = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnListStudents = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cboSubjId = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtStudentId);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.btnSubjPre);
            this.GroupBox3.Location = new System.Drawing.Point(8, 343);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(158, 109);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Subject to be Enrolled";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(9, 44);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(140, 20);
            this.txtStudentId.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Student Id :";
            // 
            // btnSubjPre
            // 
            this.btnSubjPre.Location = new System.Drawing.Point(6, 70);
            this.btnSubjPre.Name = "btnSubjPre";
            this.btnSubjPre.Size = new System.Drawing.Size(143, 26);
            this.btnSubjPre.TabIndex = 3;
            this.btnSubjPre.Text = "Preview";
            this.btnSubjPre.UseVisualStyleBackColor = true;
            this.btnSubjPre.Click += new System.EventHandler(this.btnSubjPre_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtCourse);
            this.GroupBox2.Controls.Add(this.btnCurriculum);
            this.GroupBox2.Location = new System.Drawing.Point(8, 47);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(158, 121);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Curriculum in every Course";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Course :";
            // 
            // txtCourse
            // 
            this.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourse.Location = new System.Drawing.Point(6, 44);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(146, 20);
            this.txtCourse.TabIndex = 4;
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Location = new System.Drawing.Point(6, 70);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(148, 28);
            this.btnCurriculum.TabIndex = 3;
            this.btnCurriculum.Text = "Preview";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Location = new System.Drawing.Point(4, 11);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Size = new System.Drawing.Size(163, 28);
            this.btnListStudents.TabIndex = 2;
            this.btnListStudents.Text = "List of Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(6, 53);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(151, 23);
            this.TextBox1.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(4, 174);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(163, 117);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Student Evaluation";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Student Id";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(6, 82);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(151, 29);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Print Preview";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 307);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Subject :";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.cboSubjId);
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.btnListStudents);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(174, 496);
            this.Panel1.TabIndex = 17;
            // 
            // cboSubjId
            // 
            this.cboSubjId.FormattingEnabled = true;
            this.cboSubjId.Location = new System.Drawing.Point(62, 304);
            this.cboSubjId.Name = "cboSubjId";
            this.cboSubjId.Size = new System.Drawing.Size(98, 21);
            this.cboSubjId.TabIndex = 18;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(178, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(752, 493);
            this.DataGridView1.TabIndex = 19;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 496);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSubjPre;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.Button btnCurriculum;
        internal System.Windows.Forms.Button btnListStudents;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox cboSubjId;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}