
namespace ITP_Project
{
    partial class SubjectAdding
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxYear = new System.Windows.Forms.TextBox();
            this.txtboxSubjectCode = new System.Windows.Forms.TextBox();
            this.txtBoxLabHours = new System.Windows.Forms.TextBox();
            this.txtBoxSemester = new System.Windows.Forms.TextBox();
            this.txtBoxLectureHours = new System.Windows.Forms.TextBox();
            this.txtBoxEvaluationHours = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.txtBoxTutorialHours = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tut_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluation_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(61, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Offered Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(456, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Offered Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(894, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(56, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subject Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "No Of Lecture Hours";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(640, 219);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(0, 28);
            this.comboBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(894, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "No Of Tutorial Hours";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(1050, 164);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(0, 28);
            this.comboBox6.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "No Of Lab Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "No Of Evaluation Hours";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(640, 164);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(0, 28);
            this.comboBox8.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.year,
            this.semester,
            this.subject,
            this.code,
            this.lecture_hours,
            this.tut_hours,
            this.lab_hours,
            this.evaluation_hours});
            this.dataGridView1.Location = new System.Drawing.Point(60, 339);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 396);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(898, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1029, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 42);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1161, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 42);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtboxYear
            // 
            this.txtboxYear.Location = new System.Drawing.Point(200, 104);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(206, 27);
            this.txtboxYear.TabIndex = 22;
            // 
            // txtboxSubjectCode
            // 
            this.txtboxSubjectCode.Location = new System.Drawing.Point(200, 164);
            this.txtboxSubjectCode.Name = "txtboxSubjectCode";
            this.txtboxSubjectCode.Size = new System.Drawing.Size(206, 27);
            this.txtboxSubjectCode.TabIndex = 23;
            // 
            // txtBoxLabHours
            // 
            this.txtBoxLabHours.Location = new System.Drawing.Point(200, 221);
            this.txtBoxLabHours.Name = "txtBoxLabHours";
            this.txtBoxLabHours.Size = new System.Drawing.Size(206, 27);
            this.txtBoxLabHours.TabIndex = 24;
            // 
            // txtBoxSemester
            // 
            this.txtBoxSemester.Location = new System.Drawing.Point(642, 104);
            this.txtBoxSemester.Name = "txtBoxSemester";
            this.txtBoxSemester.Size = new System.Drawing.Size(206, 27);
            this.txtBoxSemester.TabIndex = 25;
            // 
            // txtBoxLectureHours
            // 
            this.txtBoxLectureHours.Location = new System.Drawing.Point(642, 164);
            this.txtBoxLectureHours.Name = "txtBoxLectureHours";
            this.txtBoxLectureHours.Size = new System.Drawing.Size(206, 27);
            this.txtBoxLectureHours.TabIndex = 26;
            // 
            // txtBoxEvaluationHours
            // 
            this.txtBoxEvaluationHours.Location = new System.Drawing.Point(642, 221);
            this.txtBoxEvaluationHours.Name = "txtBoxEvaluationHours";
            this.txtBoxEvaluationHours.Size = new System.Drawing.Size(206, 27);
            this.txtBoxEvaluationHours.TabIndex = 27;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Location = new System.Drawing.Point(1064, 104);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(206, 27);
            this.txtBoxSubject.TabIndex = 28;
            // 
            // txtBoxTutorialHours
            // 
            this.txtBoxTutorialHours.Location = new System.Drawing.Point(1064, 164);
            this.txtBoxTutorialHours.Name = "txtBoxTutorialHours";
            this.txtBoxTutorialHours.Size = new System.Drawing.Size(206, 27);
            this.txtBoxTutorialHours.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1161, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 42);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // semester
            // 
            this.semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semester.HeaderText = "Semester";
            this.semester.MinimumWidth = 6;
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // lecture_hours
            // 
            this.lecture_hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecture_hours.HeaderText = "Lecture Hours";
            this.lecture_hours.MinimumWidth = 6;
            this.lecture_hours.Name = "lecture_hours";
            this.lecture_hours.ReadOnly = true;
            // 
            // tut_hours
            // 
            this.tut_hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tut_hours.HeaderText = "Tutorial Hours";
            this.tut_hours.MinimumWidth = 6;
            this.tut_hours.Name = "tut_hours";
            this.tut_hours.ReadOnly = true;
            // 
            // lab_hours
            // 
            this.lab_hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lab_hours.HeaderText = "Lab Hours";
            this.lab_hours.MinimumWidth = 6;
            this.lab_hours.Name = "lab_hours";
            this.lab_hours.ReadOnly = true;
            // 
            // evaluation_hours
            // 
            this.evaluation_hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evaluation_hours.HeaderText = "Evaluation Hours";
            this.evaluation_hours.MinimumWidth = 6;
            this.evaluation_hours.Name = "evaluation_hours";
            this.evaluation_hours.ReadOnly = true;
            // 
            // SubjectAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 747);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxTutorialHours);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.txtBoxEvaluationHours);
            this.Controls.Add(this.txtBoxLectureHours);
            this.Controls.Add(this.txtBoxSemester);
            this.Controls.Add(this.txtBoxLabHours);
            this.Controls.Add(this.txtboxSubjectCode);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SubjectAdding";
            this.Text = "Manage Subjects";
            this.Load += new System.EventHandler(this.SubjectAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxYear;
        private System.Windows.Forms.TextBox txtboxSubjectCode;
        private System.Windows.Forms.TextBox txtBoxLabHours;
        private System.Windows.Forms.TextBox txtBoxSemester;
        private System.Windows.Forms.TextBox txtBoxLectureHours;
        private System.Windows.Forms.TextBox txtBoxEvaluationHours;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.TextBox txtBoxTutorialHours;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn tut_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluation_hours;
    }
}