
namespace ITP_Project
{
    partial class AddUpdateSession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tags_selector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lecturer_List = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Duration = new System.Windows.Forms.NumericUpDown();
            this.NoOfStudents = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SubjectSelector = new System.Windows.Forms.ComboBox();
            this.GroupSelector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tags_selector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lecturer_List);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // tags_selector
            // 
            this.tags_selector.FormattingEnabled = true;
            this.tags_selector.Location = new System.Drawing.Point(461, 71);
            this.tags_selector.Name = "tags_selector";
            this.tags_selector.Size = new System.Drawing.Size(237, 24);
            this.tags_selector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Tag";
            // 
            // Lecturer_List
            // 
            this.Lecturer_List.FormattingEnabled = true;
            this.Lecturer_List.Location = new System.Drawing.Point(32, 71);
            this.Lecturer_List.Name = "Lecturer_List";
            this.Lecturer_List.Size = new System.Drawing.Size(381, 208);
            this.Lecturer_List.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Lecturer(s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Duration);
            this.groupBox2.Controls.Add(this.NoOfStudents);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SubjectSelector);
            this.groupBox2.Controls.Add(this.GroupSelector);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(31, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(395, 149);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(237, 22);
            this.Duration.TabIndex = 13;
            // 
            // NoOfStudents
            // 
            this.NoOfStudents.Location = new System.Drawing.Point(395, 71);
            this.NoOfStudents.Name = "NoOfStudents";
            this.NoOfStudents.Size = new System.Drawing.Size(237, 22);
            this.NoOfStudents.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hrs";
            // 
            // SubjectSelector
            // 
            this.SubjectSelector.FormattingEnabled = true;
            this.SubjectSelector.Location = new System.Drawing.Point(32, 148);
            this.SubjectSelector.Name = "SubjectSelector";
            this.SubjectSelector.Size = new System.Drawing.Size(237, 24);
            this.SubjectSelector.TabIndex = 8;
            // 
            // GroupSelector
            // 
            this.GroupSelector.FormattingEnabled = true;
            this.GroupSelector.Location = new System.Drawing.Point(32, 70);
            this.GroupSelector.Name = "GroupSelector";
            this.GroupSelector.Size = new System.Drawing.Size(237, 24);
            this.GroupSelector.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "No of Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Group";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(635, 631);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(125, 44);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddUpdateSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUpdateSession";
            this.Text = "Add / Update Session";
            this.Load += new System.EventHandler(this.AddUpdateSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tags_selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Lecturer_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SubjectSelector;
        private System.Windows.Forms.ComboBox GroupSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Duration;
        private System.Windows.Forms.NumericUpDown NoOfStudents;
    }
}