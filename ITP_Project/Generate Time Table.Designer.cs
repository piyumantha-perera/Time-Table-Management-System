
namespace ITP_Project
{
    partial class Generate_Time_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lecturer = new System.Windows.Forms.TabPage();
            this.lecturer_timetable = new System.Windows.Forms.DataGridView();
            this.lec_timeslot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec_sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturer_print = new System.Windows.Forms.Button();
            this.lecturer_generate = new System.Windows.Forms.Button();
            this.selectLecturer = new System.Windows.Forms.ComboBox();
            this.Student = new System.Windows.Forms.TabPage();
            this.StudentTimeTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.studentPrint = new System.Windows.Forms.Button();
            this.studentGenerate = new System.Windows.Forms.Button();
            this.SelectStudent = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.TabPage();
            this.locationTimeTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.locationPrint = new System.Windows.Forms.Button();
            this.locationGenerate = new System.Windows.Forms.Button();
            this.selectRoom = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.Lecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_timetable)).BeginInit();
            this.Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTimeTable)).BeginInit();
            this.Location.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lecturer);
            this.tabControl1.Controls.Add(this.Student);
            this.tabControl1.Controls.Add(this.Location);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 808);
            this.tabControl1.TabIndex = 0;
            // 
            // Lecturer
            // 
            this.Lecturer.Controls.Add(this.lecturer_timetable);
            this.Lecturer.Controls.Add(this.label1);
            this.Lecturer.Controls.Add(this.lecturer_print);
            this.Lecturer.Controls.Add(this.lecturer_generate);
            this.Lecturer.Controls.Add(this.selectLecturer);
            this.Lecturer.Location = new System.Drawing.Point(4, 25);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Padding = new System.Windows.Forms.Padding(3);
            this.Lecturer.Size = new System.Drawing.Size(1295, 779);
            this.Lecturer.TabIndex = 0;
            this.Lecturer.Text = "Lecturer";
            this.Lecturer.UseVisualStyleBackColor = true;
            // 
            // lecturer_timetable
            // 
            this.lecturer_timetable.AllowUserToAddRows = false;
            this.lecturer_timetable.AllowUserToDeleteRows = false;
            this.lecturer_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturer_timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lec_timeslot,
            this.lec_monday,
            this.lec_tuesday,
            this.lec_wednesday,
            this.lec_thursday,
            this.lec_friday,
            this.lec_saturday,
            this.lec_sunday});
            this.lecturer_timetable.Location = new System.Drawing.Point(22, 124);
            this.lecturer_timetable.Name = "lecturer_timetable";
            this.lecturer_timetable.ReadOnly = true;
            this.lecturer_timetable.RowHeadersWidth = 51;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturer_timetable.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.lecturer_timetable.RowTemplate.Height = 24;
            this.lecturer_timetable.Size = new System.Drawing.Size(1248, 633);
            this.lecturer_timetable.TabIndex = 4;
            // 
            // lec_timeslot
            // 
            this.lec_timeslot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_timeslot.HeaderText = "Time Slots";
            this.lec_timeslot.MinimumWidth = 6;
            this.lec_timeslot.Name = "lec_timeslot";
            this.lec_timeslot.ReadOnly = true;
            // 
            // lec_monday
            // 
            this.lec_monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_monday.HeaderText = "Monday";
            this.lec_monday.MinimumWidth = 6;
            this.lec_monday.Name = "lec_monday";
            this.lec_monday.ReadOnly = true;
            // 
            // lec_tuesday
            // 
            this.lec_tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_tuesday.HeaderText = "Tuesday";
            this.lec_tuesday.MinimumWidth = 6;
            this.lec_tuesday.Name = "lec_tuesday";
            this.lec_tuesday.ReadOnly = true;
            // 
            // lec_wednesday
            // 
            this.lec_wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_wednesday.HeaderText = "Wednesday";
            this.lec_wednesday.MinimumWidth = 6;
            this.lec_wednesday.Name = "lec_wednesday";
            this.lec_wednesday.ReadOnly = true;
            // 
            // lec_thursday
            // 
            this.lec_thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_thursday.HeaderText = "Thurday";
            this.lec_thursday.MinimumWidth = 6;
            this.lec_thursday.Name = "lec_thursday";
            this.lec_thursday.ReadOnly = true;
            // 
            // lec_friday
            // 
            this.lec_friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_friday.HeaderText = "Friday";
            this.lec_friday.MinimumWidth = 6;
            this.lec_friday.Name = "lec_friday";
            this.lec_friday.ReadOnly = true;
            // 
            // lec_saturday
            // 
            this.lec_saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_saturday.HeaderText = "Saturday";
            this.lec_saturday.MinimumWidth = 6;
            this.lec_saturday.Name = "lec_saturday";
            this.lec_saturday.ReadOnly = true;
            // 
            // lec_sunday
            // 
            this.lec_sunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lec_sunday.HeaderText = "Sunday";
            this.lec_sunday.MinimumWidth = 6;
            this.lec_sunday.Name = "lec_sunday";
            this.lec_sunday.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Lecturer";
            // 
            // lecturer_print
            // 
            this.lecturer_print.Location = new System.Drawing.Point(1043, 34);
            this.lecturer_print.Name = "lecturer_print";
            this.lecturer_print.Size = new System.Drawing.Size(194, 50);
            this.lecturer_print.TabIndex = 2;
            this.lecturer_print.Text = "Print";
            this.lecturer_print.UseVisualStyleBackColor = true;
            this.lecturer_print.Click += new System.EventHandler(this.lecturer_print_Click);
            // 
            // lecturer_generate
            // 
            this.lecturer_generate.Location = new System.Drawing.Point(531, 34);
            this.lecturer_generate.Name = "lecturer_generate";
            this.lecturer_generate.Size = new System.Drawing.Size(194, 50);
            this.lecturer_generate.TabIndex = 1;
            this.lecturer_generate.Text = "Generate";
            this.lecturer_generate.UseVisualStyleBackColor = true;
            this.lecturer_generate.Click += new System.EventHandler(this.lecturer_generate_Click);
            // 
            // selectLecturer
            // 
            this.selectLecturer.FormattingEnabled = true;
            this.selectLecturer.Location = new System.Drawing.Point(62, 60);
            this.selectLecturer.Name = "selectLecturer";
            this.selectLecturer.Size = new System.Drawing.Size(432, 24);
            this.selectLecturer.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.Controls.Add(this.StudentTimeTable);
            this.Student.Controls.Add(this.label2);
            this.Student.Controls.Add(this.studentPrint);
            this.Student.Controls.Add(this.studentGenerate);
            this.Student.Controls.Add(this.SelectStudent);
            this.Student.Location = new System.Drawing.Point(4, 25);
            this.Student.Name = "Student";
            this.Student.Padding = new System.Windows.Forms.Padding(3);
            this.Student.Size = new System.Drawing.Size(1295, 779);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // StudentTimeTable
            // 
            this.StudentTimeTable.AllowUserToAddRows = false;
            this.StudentTimeTable.AllowUserToDeleteRows = false;
            this.StudentTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTimeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.StudentTimeTable.Location = new System.Drawing.Point(23, 118);
            this.StudentTimeTable.Name = "StudentTimeTable";
            this.StudentTimeTable.ReadOnly = true;
            this.StudentTimeTable.RowHeadersWidth = 51;
            this.StudentTimeTable.RowTemplate.Height = 24;
            this.StudentTimeTable.Size = new System.Drawing.Size(1248, 633);
            this.StudentTimeTable.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Time Slots";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Thurday";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Saturday";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Sunday";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Student Group";
            // 
            // studentPrint
            // 
            this.studentPrint.Location = new System.Drawing.Point(1044, 28);
            this.studentPrint.Name = "studentPrint";
            this.studentPrint.Size = new System.Drawing.Size(194, 50);
            this.studentPrint.TabIndex = 7;
            this.studentPrint.Text = "Print";
            this.studentPrint.UseVisualStyleBackColor = true;
            this.studentPrint.Click += new System.EventHandler(this.studentPrint_Click);
            // 
            // studentGenerate
            // 
            this.studentGenerate.Location = new System.Drawing.Point(532, 28);
            this.studentGenerate.Name = "studentGenerate";
            this.studentGenerate.Size = new System.Drawing.Size(194, 50);
            this.studentGenerate.TabIndex = 6;
            this.studentGenerate.Text = "Generate";
            this.studentGenerate.UseVisualStyleBackColor = true;
            this.studentGenerate.Click += new System.EventHandler(this.studentGenerate_Click);
            // 
            // SelectStudent
            // 
            this.SelectStudent.FormattingEnabled = true;
            this.SelectStudent.Location = new System.Drawing.Point(63, 54);
            this.SelectStudent.Name = "SelectStudent";
            this.SelectStudent.Size = new System.Drawing.Size(432, 24);
            this.SelectStudent.TabIndex = 5;
            // 
            // Location
            // 
            this.Location.Controls.Add(this.locationTimeTable);
            this.Location.Controls.Add(this.label3);
            this.Location.Controls.Add(this.locationPrint);
            this.Location.Controls.Add(this.locationGenerate);
            this.Location.Controls.Add(this.selectRoom);
            this.Location.Location = new System.Drawing.Point(4, 25);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(1295, 779);
            this.Location.TabIndex = 2;
            this.Location.Text = "Location";
            this.Location.UseVisualStyleBackColor = true;
            // 
            // locationTimeTable
            // 
            this.locationTimeTable.AllowUserToAddRows = false;
            this.locationTimeTable.AllowUserToDeleteRows = false;
            this.locationTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationTimeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.locationTimeTable.Location = new System.Drawing.Point(23, 118);
            this.locationTimeTable.Name = "locationTimeTable";
            this.locationTimeTable.ReadOnly = true;
            this.locationTimeTable.RowHeadersWidth = 51;
            this.locationTimeTable.RowTemplate.Height = 24;
            this.locationTimeTable.Size = new System.Drawing.Size(1248, 633);
            this.locationTimeTable.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Time Slots";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Tuesday";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Wednesday";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.HeaderText = "Thurday";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.HeaderText = "Friday";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.HeaderText = "Saturday";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.HeaderText = "Sunday";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Room";
            // 
            // locationPrint
            // 
            this.locationPrint.Location = new System.Drawing.Point(1044, 28);
            this.locationPrint.Name = "locationPrint";
            this.locationPrint.Size = new System.Drawing.Size(194, 50);
            this.locationPrint.TabIndex = 7;
            this.locationPrint.Text = "Print";
            this.locationPrint.UseVisualStyleBackColor = true;
            this.locationPrint.Click += new System.EventHandler(this.locationPrint_Click);
            // 
            // locationGenerate
            // 
            this.locationGenerate.Location = new System.Drawing.Point(532, 28);
            this.locationGenerate.Name = "locationGenerate";
            this.locationGenerate.Size = new System.Drawing.Size(194, 50);
            this.locationGenerate.TabIndex = 6;
            this.locationGenerate.Text = "Generate";
            this.locationGenerate.UseVisualStyleBackColor = true;
            this.locationGenerate.Click += new System.EventHandler(this.locationGenerate_Click);
            // 
            // selectRoom
            // 
            this.selectRoom.FormattingEnabled = true;
            this.selectRoom.Location = new System.Drawing.Point(63, 54);
            this.selectRoom.Name = "selectRoom";
            this.selectRoom.Size = new System.Drawing.Size(432, 24);
            this.selectRoom.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // Generate_Time_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 832);
            this.Controls.Add(this.tabControl1);
            this.Name = "Generate_Time_Table";
            this.Text = "Generate_Time_Table";
            this.Load += new System.EventHandler(this.Generate_Time_Table_Load);
            this.tabControl1.ResumeLayout(false);
            this.Lecturer.ResumeLayout(false);
            this.Lecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_timetable)).EndInit();
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTimeTable)).EndInit();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lecturer;
        private System.Windows.Forms.DataGridView lecturer_timetable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lecturer_print;
        private System.Windows.Forms.Button lecturer_generate;
        private System.Windows.Forms.ComboBox selectLecturer;
        private System.Windows.Forms.TabPage Student;
        private System.Windows.Forms.TabPage Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_timeslot;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec_sunday;
        private System.Windows.Forms.DataGridView StudentTimeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button studentPrint;
        private System.Windows.Forms.Button studentGenerate;
        private System.Windows.Forms.ComboBox SelectStudent;
        private System.Windows.Forms.DataGridView locationTimeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button locationPrint;
        private System.Windows.Forms.Button locationGenerate;
        private System.Windows.Forms.ComboBox selectRoom;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
    }
}