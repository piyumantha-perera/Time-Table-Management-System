
namespace ITP_Project
{
    partial class add_student_group
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
            this.semAndYear = new System.Windows.Forms.ComboBox();
            this.progrm = new System.Windows.Forms.Label();
            this.programme = new System.Windows.Forms.ComboBox();
            this.grpNumber = new System.Windows.Forms.Label();
            this.grpNum = new System.Windows.Forms.TextBox();
            this.subGrpNumber = new System.Windows.Forms.Label();
            this.subGrpNum = new System.Windows.Forms.TextBox();
            this.grpId = new System.Windows.Forms.Label();
            this.subGrpId = new System.Windows.Forms.Label();
            this.grpIdText = new System.Windows.Forms.TextBox();
            this.SubgrpIdText = new System.Windows.Forms.TextBox();
            this.generateIdBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_group_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-132, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Acedemic Year and  Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Student Groups";
            // 
            // semAndYear
            // 
            this.semAndYear.AutoCompleteCustomSource.AddRange(new string[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.semAndYear.FormattingEnabled = true;
            this.semAndYear.Items.AddRange(new object[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.semAndYear.Location = new System.Drawing.Point(244, 84);
            this.semAndYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.semAndYear.Name = "semAndYear";
            this.semAndYear.Size = new System.Drawing.Size(201, 24);
            this.semAndYear.TabIndex = 5;
            this.semAndYear.SelectedIndexChanged += new System.EventHandler(this.semAndYear_SelectedIndexChanged);
            // 
            // progrm
            // 
            this.progrm.AutoSize = true;
            this.progrm.Location = new System.Drawing.Point(23, 133);
            this.progrm.Name = "progrm";
            this.progrm.Size = new System.Drawing.Size(81, 17);
            this.progrm.TabIndex = 3;
            this.progrm.Text = "Programme";
            // 
            // programme
            // 
            this.programme.AutoCompleteCustomSource.AddRange(new string[] {
            "IT",
            "CS",
            "DS",
            "IM",
            "SE"});
            this.programme.FormattingEnabled = true;
            this.programme.Items.AddRange(new object[] {
            "IT",
            "CS",
            "DS",
            "SE",
            "IM"});
            this.programme.Location = new System.Drawing.Point(244, 133);
            this.programme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(201, 24);
            this.programme.TabIndex = 5;
            // 
            // grpNumber
            // 
            this.grpNumber.AutoSize = true;
            this.grpNumber.Location = new System.Drawing.Point(23, 189);
            this.grpNumber.Name = "grpNumber";
            this.grpNumber.Size = new System.Drawing.Size(102, 17);
            this.grpNumber.TabIndex = 3;
            this.grpNumber.Text = "Group Number";
            // 
            // grpNum
            // 
            this.grpNum.Location = new System.Drawing.Point(244, 186);
            this.grpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNum.Name = "grpNum";
            this.grpNum.Size = new System.Drawing.Size(201, 22);
            this.grpNum.TabIndex = 6;
            // 
            // subGrpNumber
            // 
            this.subGrpNumber.AutoSize = true;
            this.subGrpNumber.Location = new System.Drawing.Point(23, 241);
            this.subGrpNumber.Name = "subGrpNumber";
            this.subGrpNumber.Size = new System.Drawing.Size(131, 17);
            this.subGrpNumber.TabIndex = 3;
            this.subGrpNumber.Text = "Sub Group Number";
            this.subGrpNumber.Click += new System.EventHandler(this.label4_Click);
            // 
            // subGrpNum
            // 
            this.subGrpNum.Location = new System.Drawing.Point(244, 238);
            this.subGrpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subGrpNum.Name = "subGrpNum";
            this.subGrpNum.Size = new System.Drawing.Size(201, 22);
            this.subGrpNum.TabIndex = 6;
            this.subGrpNum.TextChanged += new System.EventHandler(this.subGrpNum_TextChanged);
            // 
            // grpId
            // 
            this.grpId.AutoSize = true;
            this.grpId.Location = new System.Drawing.Point(592, 90);
            this.grpId.Name = "grpId";
            this.grpId.Size = new System.Drawing.Size(65, 17);
            this.grpId.TabIndex = 3;
            this.grpId.Text = "Group ID";
            this.grpId.Click += new System.EventHandler(this.label4_Click);
            // 
            // subGrpId
            // 
            this.subGrpId.AutoSize = true;
            this.subGrpId.Location = new System.Drawing.Point(592, 133);
            this.subGrpId.Name = "subGrpId";
            this.subGrpId.Size = new System.Drawing.Size(94, 17);
            this.subGrpId.TabIndex = 3;
            this.subGrpId.Text = "Sub Group ID";
            this.subGrpId.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpIdText
            // 
            this.grpIdText.Location = new System.Drawing.Point(753, 84);
            this.grpIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIdText.Name = "grpIdText";
            this.grpIdText.Size = new System.Drawing.Size(201, 22);
            this.grpIdText.TabIndex = 6;
            // 
            // SubgrpIdText
            // 
            this.SubgrpIdText.Location = new System.Drawing.Point(753, 130);
            this.SubgrpIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubgrpIdText.Name = "SubgrpIdText";
            this.SubgrpIdText.Size = new System.Drawing.Size(201, 22);
            this.SubgrpIdText.TabIndex = 6;
            // 
            // generateIdBtn
            // 
            this.generateIdBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generateIdBtn.Location = new System.Drawing.Point(821, 173);
            this.generateIdBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateIdBtn.Name = "generateIdBtn";
            this.generateIdBtn.Size = new System.Drawing.Size(133, 33);
            this.generateIdBtn.TabIndex = 7;
            this.generateIdBtn.Text = "Generate IDs";
            this.generateIdBtn.UseVisualStyleBackColor = false;
            this.generateIdBtn.Click += new System.EventHandler(this.generateIdBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.Info;
            this.insertBtn.Location = new System.Drawing.Point(676, 296);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(133, 33);
            this.insertBtn.TabIndex = 7;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Info;
            this.updateBtn.Location = new System.Drawing.Point(824, 296);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 33);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Info;
            this.deleteBtn.Location = new System.Drawing.Point(21, 296);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 33);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Info;
            this.clearBtn.Location = new System.Drawing.Point(174, 296);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 33);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.year_semester,
            this.program,
            this.group_no,
            this.sub_group_no,
            this.group_id,
            this.sub_group_id});
            this.dataGridView1.Location = new System.Drawing.Point(23, 352);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 319);
            this.dataGridView1.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // year_semester
            // 
            this.year_semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year_semester.HeaderText = "Acedemic Year Semester";
            this.year_semester.MinimumWidth = 6;
            this.year_semester.Name = "year_semester";
            this.year_semester.ReadOnly = true;
            // 
            // program
            // 
            this.program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.program.HeaderText = "Programme";
            this.program.MinimumWidth = 6;
            this.program.Name = "program";
            this.program.ReadOnly = true;
            // 
            // group_no
            // 
            this.group_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group_no.HeaderText = "Group No";
            this.group_no.MinimumWidth = 6;
            this.group_no.Name = "group_no";
            this.group_no.ReadOnly = true;
            // 
            // sub_group_no
            // 
            this.sub_group_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sub_group_no.HeaderText = "Sub Group No";
            this.sub_group_no.MinimumWidth = 6;
            this.sub_group_no.Name = "sub_group_no";
            this.sub_group_no.ReadOnly = true;
            // 
            // group_id
            // 
            this.group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group_id.HeaderText = "Group Id";
            this.group_id.MinimumWidth = 6;
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            // 
            // sub_group_id
            // 
            this.sub_group_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sub_group_id.HeaderText = "Sub Group Id";
            this.sub_group_id.MinimumWidth = 6;
            this.sub_group_id.Name = "sub_group_id";
            this.sub_group_id.ReadOnly = true;
            // 
            // add_student_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.generateIdBtn);
            this.Controls.Add(this.subGrpNum);
            this.Controls.Add(this.SubgrpIdText);
            this.Controls.Add(this.grpIdText);
            this.Controls.Add(this.grpNum);
            this.Controls.Add(this.programme);
            this.Controls.Add(this.semAndYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subGrpId);
            this.Controls.Add(this.grpId);
            this.Controls.Add(this.subGrpNumber);
            this.Controls.Add(this.grpNumber);
            this.Controls.Add(this.progrm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "add_student_group";
            this.Text = "Manage Student Groups";
            this.Load += new System.EventHandler(this.add_student_group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox semAndYear;
        private System.Windows.Forms.Label progrm;
        private System.Windows.Forms.ComboBox programme;
        private System.Windows.Forms.Label grpNumber;
        private System.Windows.Forms.TextBox grpNum;
        private System.Windows.Forms.Label subGrpNumber;
        private System.Windows.Forms.TextBox subGrpNum;
        private System.Windows.Forms.Label grpId;
        private System.Windows.Forms.Label subGrpId;
        private System.Windows.Forms.TextBox grpIdText;
        private System.Windows.Forms.TextBox SubgrpIdText;
        private System.Windows.Forms.Button generateIdBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private string connectionString = "server=database-itpm.cmahd6rnztyt.ap-south-1.rds.amazonaws.com;user=root;password=root_toor;database=itpm";
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn program;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_group_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_group_id;
    }
}