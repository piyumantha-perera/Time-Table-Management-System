
namespace ITP_Project
{
    partial class manage_sessions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SessionTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture_one = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecture_two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearchOption = new System.Windows.Forms.ComboBox();
            this.txtSearchHint = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.add_consecutive_session = new System.Windows.Forms.Button();
            this.ConsicutiveSessions = new System.Windows.Forms.DataGridView();
            this.consecutive_session_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutive_session_lecturer_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutive_session_lecturer_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutive_session_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutive_session_group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutive_session_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Parallel_Manage_Session = new System.Windows.Forms.Button();
            this.Parallel_Sessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Add_Non_Overlapping_Session = new System.Windows.Forms.Button();
            this.Non_Overlapping_Sessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnDeleteNAT = new System.Windows.Forms.Button();
            this.Non_Available_Time_Table = new System.Windows.Forms.DataGridView();
            this.nat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_subgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNATime = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsicutiveSessions)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parallel_Sessions)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Non_Overlapping_Sessions)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Non_Available_Time_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.SessionTable);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(603, 620);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 48);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(755, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 48);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SessionTable
            // 
            this.SessionTable.AllowUserToAddRows = false;
            this.SessionTable.AllowUserToDeleteRows = false;
            this.SessionTable.AllowUserToOrderColumns = true;
            this.SessionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lecture_one,
            this.lecture_two,
            this.subject_name,
            this.group_id,
            this.tag,
            this.students,
            this.duration});
            this.SessionTable.Location = new System.Drawing.Point(26, 168);
            this.SessionTable.Name = "SessionTable";
            this.SessionTable.ReadOnly = true;
            this.SessionTable.RowHeadersWidth = 51;
            this.SessionTable.RowTemplate.Height = 24;
            this.SessionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionTable.Size = new System.Drawing.Size(1004, 434);
            this.SessionTable.TabIndex = 6;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // lecture_one
            // 
            this.lecture_one.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecture_one.HeaderText = "Lecturer 1";
            this.lecture_one.MinimumWidth = 6;
            this.lecture_one.Name = "lecture_one";
            this.lecture_one.ReadOnly = true;
            // 
            // lecture_two
            // 
            this.lecture_two.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecture_two.HeaderText = "Lecturer 2";
            this.lecture_two.MinimumWidth = 6;
            this.lecture_two.Name = "lecture_two";
            this.lecture_two.ReadOnly = true;
            // 
            // subject_name
            // 
            this.subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject_name.HeaderText = "Subject";
            this.subject_name.MinimumWidth = 6;
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            // 
            // group_id
            // 
            this.group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group_id.HeaderText = "Group";
            this.group_id.MinimumWidth = 6;
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // students
            // 
            this.students.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.students.HeaderText = "Students";
            this.students.MinimumWidth = 6;
            this.students.Name = "students";
            this.students.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duration.HeaderText = "Duration";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.comboSearchOption);
            this.groupBox1.Controls.Add(this.txtSearchHint);
            this.groupBox1.Location = new System.Drawing.Point(26, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Key";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(811, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 47);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboSearchOption
            // 
            this.comboSearchOption.FormattingEnabled = true;
            this.comboSearchOption.Items.AddRange(new object[] {
            "Lecturer",
            "Subject",
            "Group",
            "Tag"});
            this.comboSearchOption.Location = new System.Drawing.Point(540, 66);
            this.comboSearchOption.Name = "comboSearchOption";
            this.comboSearchOption.Size = new System.Drawing.Size(236, 24);
            this.comboSearchOption.TabIndex = 2;
            // 
            // txtSearchHint
            // 
            this.txtSearchHint.Location = new System.Drawing.Point(35, 66);
            this.txtSearchHint.Name = "txtSearchHint";
            this.txtSearchHint.Size = new System.Drawing.Size(465, 22);
            this.txtSearchHint.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Allocations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1052, 679);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.add_consecutive_session);
            this.tabPage3.Controls.Add(this.ConsicutiveSessions);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1044, 650);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Consecutive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // add_consecutive_session
            // 
            this.add_consecutive_session.Location = new System.Drawing.Point(849, 590);
            this.add_consecutive_session.Name = "add_consecutive_session";
            this.add_consecutive_session.Size = new System.Drawing.Size(189, 54);
            this.add_consecutive_session.TabIndex = 1;
            this.add_consecutive_session.Text = "Manage Sessions";
            this.add_consecutive_session.UseVisualStyleBackColor = true;
            this.add_consecutive_session.Click += new System.EventHandler(this.add_consecutive_session_Click);
            // 
            // ConsicutiveSessions
            // 
            this.ConsicutiveSessions.AllowUserToAddRows = false;
            this.ConsicutiveSessions.AllowUserToDeleteRows = false;
            this.ConsicutiveSessions.AllowUserToOrderColumns = true;
            this.ConsicutiveSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsicutiveSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consecutive_session_id,
            this.consecutive_session_lecturer_1,
            this.consecutive_session_lecturer_2,
            this.consecutive_session_subject,
            this.consecutive_session_group_id,
            this.consecutive_session_tag});
            this.ConsicutiveSessions.Location = new System.Drawing.Point(3, 3);
            this.ConsicutiveSessions.MultiSelect = false;
            this.ConsicutiveSessions.Name = "ConsicutiveSessions";
            this.ConsicutiveSessions.RowHeadersWidth = 51;
            this.ConsicutiveSessions.RowTemplate.Height = 24;
            this.ConsicutiveSessions.Size = new System.Drawing.Size(1038, 581);
            this.ConsicutiveSessions.TabIndex = 0;
            // 
            // consecutive_session_id
            // 
            this.consecutive_session_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_id.HeaderText = "ID";
            this.consecutive_session_id.MinimumWidth = 6;
            this.consecutive_session_id.Name = "consecutive_session_id";
            this.consecutive_session_id.ReadOnly = true;
            // 
            // consecutive_session_lecturer_1
            // 
            this.consecutive_session_lecturer_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_lecturer_1.HeaderText = "Lecturer 1";
            this.consecutive_session_lecturer_1.MinimumWidth = 6;
            this.consecutive_session_lecturer_1.Name = "consecutive_session_lecturer_1";
            this.consecutive_session_lecturer_1.ReadOnly = true;
            // 
            // consecutive_session_lecturer_2
            // 
            this.consecutive_session_lecturer_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_lecturer_2.HeaderText = "Lecturer 2";
            this.consecutive_session_lecturer_2.MinimumWidth = 6;
            this.consecutive_session_lecturer_2.Name = "consecutive_session_lecturer_2";
            this.consecutive_session_lecturer_2.ReadOnly = true;
            // 
            // consecutive_session_subject
            // 
            this.consecutive_session_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_subject.HeaderText = "Subject";
            this.consecutive_session_subject.MinimumWidth = 6;
            this.consecutive_session_subject.Name = "consecutive_session_subject";
            this.consecutive_session_subject.ReadOnly = true;
            // 
            // consecutive_session_group_id
            // 
            this.consecutive_session_group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_group_id.HeaderText = "Group ID";
            this.consecutive_session_group_id.MinimumWidth = 6;
            this.consecutive_session_group_id.Name = "consecutive_session_group_id";
            this.consecutive_session_group_id.ReadOnly = true;
            // 
            // consecutive_session_tag
            // 
            this.consecutive_session_tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consecutive_session_tag.HeaderText = "Tag";
            this.consecutive_session_tag.MinimumWidth = 6;
            this.consecutive_session_tag.Name = "consecutive_session_tag";
            this.consecutive_session_tag.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Parallel_Manage_Session);
            this.tabPage4.Controls.Add(this.Parallel_Sessions);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1044, 650);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Parallel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Parallel_Manage_Session
            // 
            this.Parallel_Manage_Session.Location = new System.Drawing.Point(812, 590);
            this.Parallel_Manage_Session.Name = "Parallel_Manage_Session";
            this.Parallel_Manage_Session.Size = new System.Drawing.Size(226, 54);
            this.Parallel_Manage_Session.TabIndex = 3;
            this.Parallel_Manage_Session.Text = "Manage Sessions";
            this.Parallel_Manage_Session.UseVisualStyleBackColor = true;
            this.Parallel_Manage_Session.Click += new System.EventHandler(this.Parallel_Manage_Session_Click);
            // 
            // Parallel_Sessions
            // 
            this.Parallel_Sessions.AllowUserToAddRows = false;
            this.Parallel_Sessions.AllowUserToDeleteRows = false;
            this.Parallel_Sessions.AllowUserToOrderColumns = true;
            this.Parallel_Sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parallel_Sessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.Parallel_Sessions.Location = new System.Drawing.Point(3, 3);
            this.Parallel_Sessions.MultiSelect = false;
            this.Parallel_Sessions.Name = "Parallel_Sessions";
            this.Parallel_Sessions.RowHeadersWidth = 51;
            this.Parallel_Sessions.RowTemplate.Height = 24;
            this.Parallel_Sessions.Size = new System.Drawing.Size(1038, 581);
            this.Parallel_Sessions.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Lecturer 1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Lecturer 2";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Group ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Add_Non_Overlapping_Session);
            this.tabPage5.Controls.Add(this.Non_Overlapping_Sessions);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1044, 650);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Non Overlapping";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Add_Non_Overlapping_Session
            // 
            this.Add_Non_Overlapping_Session.Location = new System.Drawing.Point(815, 591);
            this.Add_Non_Overlapping_Session.Name = "Add_Non_Overlapping_Session";
            this.Add_Non_Overlapping_Session.Size = new System.Drawing.Size(226, 54);
            this.Add_Non_Overlapping_Session.TabIndex = 2;
            this.Add_Non_Overlapping_Session.Text = "Manage Sessions";
            this.Add_Non_Overlapping_Session.UseVisualStyleBackColor = true;
            this.Add_Non_Overlapping_Session.Click += new System.EventHandler(this.Add_Non_Overlapping_Session_Click);
            // 
            // Non_Overlapping_Sessions
            // 
            this.Non_Overlapping_Sessions.AllowUserToAddRows = false;
            this.Non_Overlapping_Sessions.AllowUserToDeleteRows = false;
            this.Non_Overlapping_Sessions.AllowUserToOrderColumns = true;
            this.Non_Overlapping_Sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Non_Overlapping_Sessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.Non_Overlapping_Sessions.Location = new System.Drawing.Point(3, 5);
            this.Non_Overlapping_Sessions.MultiSelect = false;
            this.Non_Overlapping_Sessions.Name = "Non_Overlapping_Sessions";
            this.Non_Overlapping_Sessions.RowHeadersWidth = 51;
            this.Non_Overlapping_Sessions.RowTemplate.Height = 24;
            this.Non_Overlapping_Sessions.Size = new System.Drawing.Size(1038, 581);
            this.Non_Overlapping_Sessions.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lecturer 1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Lecturer 2";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Group ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnDeleteNAT);
            this.tabPage6.Controls.Add(this.Non_Available_Time_Table);
            this.tabPage6.Controls.Add(this.btnAddNATime);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1044, 650);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Non Available Times";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNAT
            // 
            this.btnDeleteNAT.Location = new System.Drawing.Point(727, 590);
            this.btnDeleteNAT.Name = "btnDeleteNAT";
            this.btnDeleteNAT.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteNAT.TabIndex = 2;
            this.btnDeleteNAT.Text = "Delete";
            this.btnDeleteNAT.UseVisualStyleBackColor = true;
            this.btnDeleteNAT.Click += new System.EventHandler(this.btnDeleteNAT_Click);
            // 
            // Non_Available_Time_Table
            // 
            this.Non_Available_Time_Table.AllowUserToAddRows = false;
            this.Non_Available_Time_Table.AllowUserToDeleteRows = false;
            this.Non_Available_Time_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Non_Available_Time_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nat_id,
            this.nat_session,
            this.nat_lecturer,
            this.nat_group,
            this.nat_subgroup,
            this.nat_day,
            this.nat_time});
            this.Non_Available_Time_Table.Location = new System.Drawing.Point(3, 3);
            this.Non_Available_Time_Table.MultiSelect = false;
            this.Non_Available_Time_Table.Name = "Non_Available_Time_Table";
            this.Non_Available_Time_Table.ReadOnly = true;
            this.Non_Available_Time_Table.RowHeadersWidth = 51;
            this.Non_Available_Time_Table.RowTemplate.Height = 24;
            this.Non_Available_Time_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Non_Available_Time_Table.Size = new System.Drawing.Size(1038, 565);
            this.Non_Available_Time_Table.TabIndex = 1;
            // 
            // nat_id
            // 
            this.nat_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_id.HeaderText = "ID";
            this.nat_id.MinimumWidth = 6;
            this.nat_id.Name = "nat_id";
            this.nat_id.ReadOnly = true;
            // 
            // nat_session
            // 
            this.nat_session.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_session.HeaderText = "Session ID";
            this.nat_session.MinimumWidth = 6;
            this.nat_session.Name = "nat_session";
            this.nat_session.ReadOnly = true;
            // 
            // nat_lecturer
            // 
            this.nat_lecturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_lecturer.HeaderText = "Lecturer";
            this.nat_lecturer.MinimumWidth = 6;
            this.nat_lecturer.Name = "nat_lecturer";
            this.nat_lecturer.ReadOnly = true;
            // 
            // nat_group
            // 
            this.nat_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_group.HeaderText = "Group";
            this.nat_group.MinimumWidth = 6;
            this.nat_group.Name = "nat_group";
            this.nat_group.ReadOnly = true;
            // 
            // nat_subgroup
            // 
            this.nat_subgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_subgroup.HeaderText = "Sub Group";
            this.nat_subgroup.MinimumWidth = 6;
            this.nat_subgroup.Name = "nat_subgroup";
            this.nat_subgroup.ReadOnly = true;
            // 
            // nat_day
            // 
            this.nat_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_day.HeaderText = "Day";
            this.nat_day.MinimumWidth = 6;
            this.nat_day.Name = "nat_day";
            this.nat_day.ReadOnly = true;
            // 
            // nat_time
            // 
            this.nat_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_time.HeaderText = "Time";
            this.nat_time.MinimumWidth = 6;
            this.nat_time.Name = "nat_time";
            this.nat_time.ReadOnly = true;
            // 
            // btnAddNATime
            // 
            this.btnAddNATime.Location = new System.Drawing.Point(890, 590);
            this.btnAddNATime.Name = "btnAddNATime";
            this.btnAddNATime.Size = new System.Drawing.Size(142, 44);
            this.btnAddNATime.TabIndex = 0;
            this.btnAddNATime.Text = "Add New";
            this.btnAddNATime.UseVisualStyleBackColor = true;
            this.btnAddNATime.Click += new System.EventHandler(this.btnAddNATime_Click);
            // 
            // manage_sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 714);
            this.Controls.Add(this.tabControl1);
            this.Name = "manage_sessions";
            this.Text = "Manage Sessions";
            this.Load += new System.EventHandler(this.manage_sessions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SessionTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsicutiveSessions)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Parallel_Sessions)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Non_Overlapping_Sessions)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Non_Available_Time_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView SessionTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearchOption;
        private System.Windows.Forms.TextBox txtSearchHint;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView ConsicutiveSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecture_two;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn students;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.Button add_consecutive_session;
        private System.Windows.Forms.Button Add_Non_Overlapping_Session;
        private System.Windows.Forms.DataGridView Non_Overlapping_Sessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_lecturer_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_lecturer_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutive_session_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView Parallel_Sessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button Parallel_Manage_Session;
        private System.Windows.Forms.Button btnAddNATime;
        private System.Windows.Forms.DataGridView Non_Available_Time_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_lecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_subgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_time;
        private System.Windows.Forms.Button btnDeleteNAT;
    }
}