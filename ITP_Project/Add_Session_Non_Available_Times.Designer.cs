
namespace ITP_Project
{
    partial class Add_Session_Non_Available_Times
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.comboSubGroup = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboLecturer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "HH:mm tt";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(294, 186);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 23;
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday "});
            this.comboDay.Location = new System.Drawing.Point(47, 184);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(200, 24);
            this.comboDay.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Select Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Select Day";
            // 
            // comboSession
            // 
            this.comboSession.FormattingEnabled = true;
            this.comboSession.Location = new System.Drawing.Point(789, 76);
            this.comboSession.Name = "comboSession";
            this.comboSession.Size = new System.Drawing.Size(200, 24);
            this.comboSession.TabIndex = 19;
            // 
            // comboSubGroup
            // 
            this.comboSubGroup.FormattingEnabled = true;
            this.comboSubGroup.Location = new System.Drawing.Point(542, 76);
            this.comboSubGroup.Name = "comboSubGroup";
            this.comboSubGroup.Size = new System.Drawing.Size(200, 24);
            this.comboSubGroup.TabIndex = 18;
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(294, 76);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(200, 24);
            this.comboGroup.TabIndex = 17;
            // 
            // comboLecturer
            // 
            this.comboLecturer.FormattingEnabled = true;
            this.comboLecturer.Location = new System.Drawing.Point(47, 76);
            this.comboLecturer.Name = "comboLecturer";
            this.comboLecturer.Size = new System.Drawing.Size(200, 24);
            this.comboLecturer.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(786, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select Session ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select SubGroup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Lecturer";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(789, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 56);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Add_Session_Non_Available_Times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 424);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboSession);
            this.Controls.Add(this.comboSubGroup);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.comboLecturer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Add_Session_Non_Available_Times";
            this.Text = "Add Session Non Available Times";
            this.Load += new System.EventHandler(this.Add_Session_Non_Available_Times_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSession;
        private System.Windows.Forms.ComboBox comboSubGroup;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboLecturer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}