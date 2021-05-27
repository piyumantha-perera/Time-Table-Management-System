
namespace ITP_Project
{
    partial class LectureAdding
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
            this.lectureName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.level = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_lecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_center = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rank = new System.Windows.Forms.TextBox();
            this.center = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.empId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecture Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lectureName
            // 
            this.lectureName.Location = new System.Drawing.Point(177, 75);
            this.lectureName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lectureName.Name = "lectureName";
            this.lectureName.Size = new System.Drawing.Size(243, 22);
            this.lectureName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Building";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Faculty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Rank";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // building
            // 
            this.building.FormattingEnabled = true;
            this.building.Items.AddRange(new object[] {
            "Main Building",
            "New IT Building",
            "Ground Side Buiing"});
            this.building.Location = new System.Drawing.Point(177, 130);
            this.building.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(243, 24);
            this.building.TabIndex = 11;
            // 
            // faculty
            // 
            this.faculty.FormattingEnabled = true;
            this.faculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Arts"});
            this.faculty.Location = new System.Drawing.Point(577, 132);
            this.faculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(243, 24);
            this.faculty.TabIndex = 12;
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.level.Location = new System.Drawing.Point(973, 132);
            this.level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(243, 24);
            this.level.TabIndex = 13;
            this.level.SelectedIndexChanged += new System.EventHandler(this.level_SelectedIndexChanged);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Cyber Security",
            "Software Engineering",
            "Civil Engineering",
            "Inerective Media"});
            this.department.Location = new System.Drawing.Point(177, 189);
            this.department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(243, 24);
            this.department.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_lecture,
            this.c_center,
            this.c_building,
            this.c_faculty,
            this.c_level,
            this.c_department,
            this.c_rank});
            this.dataGridView1.Location = new System.Drawing.Point(70, 305);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 343);
            this.dataGridView1.TabIndex = 16;
            // 
            // c_id
            // 
            this.c_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_id.HeaderText = "ID";
            this.c_id.MinimumWidth = 6;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            // 
            // c_lecture
            // 
            this.c_lecture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_lecture.HeaderText = "Lecture";
            this.c_lecture.MinimumWidth = 6;
            this.c_lecture.Name = "c_lecture";
            this.c_lecture.ReadOnly = true;
            // 
            // c_center
            // 
            this.c_center.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_center.HeaderText = "Center";
            this.c_center.MinimumWidth = 6;
            this.c_center.Name = "c_center";
            this.c_center.ReadOnly = true;
            // 
            // c_building
            // 
            this.c_building.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_building.HeaderText = "Building";
            this.c_building.MinimumWidth = 6;
            this.c_building.Name = "c_building";
            this.c_building.ReadOnly = true;
            // 
            // c_faculty
            // 
            this.c_faculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_faculty.HeaderText = "Faculty";
            this.c_faculty.MinimumWidth = 6;
            this.c_faculty.Name = "c_faculty";
            this.c_faculty.ReadOnly = true;
            // 
            // c_level
            // 
            this.c_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_level.HeaderText = "Level";
            this.c_level.MinimumWidth = 6;
            this.c_level.Name = "c_level";
            this.c_level.ReadOnly = true;
            // 
            // c_department
            // 
            this.c_department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_department.HeaderText = "Department";
            this.c_department.MinimumWidth = 6;
            this.c_department.Name = "c_department";
            this.c_department.ReadOnly = true;
            // 
            // c_rank
            // 
            this.c_rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_rank.HeaderText = "Rank";
            this.c_rank.MinimumWidth = 6;
            this.c_rank.Name = "c_rank";
            this.c_rank.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(68, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lecture Details";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(856, 189);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 33);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(978, 190);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 33);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1100, 190);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(577, 189);
            this.rank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Size = new System.Drawing.Size(243, 22);
            this.rank.TabIndex = 21;
            // 
            // center
            // 
            this.center.FormattingEnabled = true;
            this.center.Items.AddRange(new object[] {
            "Kandy",
            "Malabe",
            "Metro",
            "Jaffna"});
            this.center.Location = new System.Drawing.Point(577, 71);
            this.center.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(243, 24);
            this.center.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1100, 244);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 33);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // empId
            // 
            this.empId.Location = new System.Drawing.Point(973, 71);
            this.empId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Size = new System.Drawing.Size(243, 22);
            this.empId.TabIndex = 25;
            // 
            // LectureAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 703);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.center);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.department);
            this.Controls.Add(this.level);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.building);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lectureName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LectureAdding";
            this.Text = "Manage Lecture";
            this.Load += new System.EventHandler(this.LectureAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lectureName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.ComboBox center;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_lecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_center;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_building;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_rank;
        private string connectionString = "server=database-itpm.cmahd6rnztyt.ap-south-1.rds.amazonaws.com;user=root;password=root_toor;database=itpm";
    }
}