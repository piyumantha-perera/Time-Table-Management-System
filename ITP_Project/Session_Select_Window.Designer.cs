
namespace ITP_Project
{
    partial class Session_Select_Window
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
            this.SessionTable = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SessionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionTable
            // 
            this.SessionTable.AllowUserToAddRows = false;
            this.SessionTable.AllowUserToDeleteRows = false;
            this.SessionTable.AllowUserToOrderColumns = true;
            this.SessionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.id,
            this.lecturer_1,
            this.lecturer_2,
            this.subject,
            this.group,
            this.tag});
            this.SessionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionTable.GridColor = System.Drawing.SystemColors.Control;
            this.SessionTable.Location = new System.Drawing.Point(0, 0);
            this.SessionTable.MultiSelect = false;
            this.SessionTable.Name = "SessionTable";
            this.SessionTable.ReadOnly = true;
            this.SessionTable.RowHeadersWidth = 51;
            this.SessionTable.RowTemplate.Height = 24;
            this.SessionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionTable.Size = new System.Drawing.Size(1099, 637);
            this.SessionTable.TabIndex = 0;
            this.SessionTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SessionTable_CellContentClick);
            // 
            // checkbox
            // 
            this.checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkbox.HeaderText = "#";
            this.checkbox.MinimumWidth = 6;
            this.checkbox.Name = "checkbox";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // lecturer_1
            // 
            this.lecturer_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecturer_1.HeaderText = "Lecturer 1";
            this.lecturer_1.MinimumWidth = 6;
            this.lecturer_1.Name = "lecturer_1";
            // 
            // lecturer_2
            // 
            this.lecturer_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lecturer_2.HeaderText = "Lecturer 2";
            this.lecturer_2.MinimumWidth = 6;
            this.lecturer_2.Name = "lecturer_2";
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            // 
            // group
            // 
            this.group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            // 
            // Session_Select_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 637);
            this.Controls.Add(this.SessionTable);
            this.Name = "Session_Select_Window";
            this.Text = "Select Sessions";
            this.Load += new System.EventHandler(this.Session_Select_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SessionTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
    }
}