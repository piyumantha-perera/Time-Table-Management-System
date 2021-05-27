namespace ITP_Project
{
    partial class Add_Locations
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
            this.roomType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.inserBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Sessions = new System.Windows.Forms.TabPage();
            this.Add_Session_Room_Btn = new System.Windows.Forms.Button();
            this.comboRooms = new System.Windows.Forms.ComboBox();
            this.comboSessions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SessionRoomAllocationTable = new System.Windows.Forms.DataGridView();
            this.sr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_lecturer_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_lecturer_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.natDel = new System.Windows.Forms.Button();
            this.natAdd = new System.Windows.Forms.Button();
            this.selectSlot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectRooms = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Non_Available_Time_Slot_Table = new System.Windows.Forms.DataGridView();
            this.nat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nat_timeslot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Sessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionRoomAllocationTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Non_Available_Time_Slot_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 905);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.roomType);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Updatebtn);
            this.tabPage1.Controls.Add(this.inserBtn);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.Clearbtn);
            this.tabPage1.Controls.Add(this.txtCapacity);
            this.tabPage1.Controls.Add(this.txtRoom);
            this.tabPage1.Controls.Add(this.txtBuilding);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 865);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Items.AddRange(new object[] {
            "Laboratory",
            "Lecture Hall"});
            this.roomType.Location = new System.Drawing.Point(737, 67);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(270, 35);
            this.roomType.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.building,
            this.room,
            this.type,
            this.capacity});
            this.dataGridView1.Location = new System.Drawing.Point(24, 264);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 578);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // building
            // 
            this.building.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.building.HeaderText = "Building";
            this.building.MinimumWidth = 6;
            this.building.Name = "building";
            this.building.ReadOnly = true;
            // 
            // room
            // 
            this.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.room.HeaderText = "Room";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.HeaderText = "Capacity";
            this.capacity.MinimumWidth = 6;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Updatebtn.Location = new System.Drawing.Point(562, 178);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(106, 37);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // inserBtn
            // 
            this.inserBtn.Font = new System.Drawing.Font("Arial", 13.8F);
            this.inserBtn.Location = new System.Drawing.Point(382, 178);
            this.inserBtn.Name = "inserBtn";
            this.inserBtn.Size = new System.Drawing.Size(106, 37);
            this.inserBtn.TabIndex = 15;
            this.inserBtn.Text = "Insert";
            this.inserBtn.UseVisualStyleBackColor = true;
            this.inserBtn.Click += new System.EventHandler(this.inserBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 13.8F);
            this.deleteBtn.Location = new System.Drawing.Point(732, 178);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(106, 37);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Clearbtn.Location = new System.Drawing.Point(901, 178);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(106, 37);
            this.Clearbtn.TabIndex = 17;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(24, 180);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(314, 34);
            this.txtCapacity.TabIndex = 11;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(382, 67);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(314, 34);
            this.txtRoom.TabIndex = 12;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(24, 67);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(314, 34);
            this.txtBuilding.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label10.Location = new System.Drawing.Point(19, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label7.Location = new System.Drawing.Point(732, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label6.Location = new System.Drawing.Point(377, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Building Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 865);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Allocations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Sessions);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1036, 859);
            this.tabControl2.TabIndex = 7;
            // 
            // Sessions
            // 
            this.Sessions.Controls.Add(this.Add_Session_Room_Btn);
            this.Sessions.Controls.Add(this.comboRooms);
            this.Sessions.Controls.Add(this.comboSessions);
            this.Sessions.Controls.Add(this.label3);
            this.Sessions.Controls.Add(this.label1);
            this.Sessions.Controls.Add(this.SessionRoomAllocationTable);
            this.Sessions.Controls.Add(this.btnDelete);
            this.Sessions.Location = new System.Drawing.Point(4, 36);
            this.Sessions.Name = "Sessions";
            this.Sessions.Padding = new System.Windows.Forms.Padding(3);
            this.Sessions.Size = new System.Drawing.Size(1028, 819);
            this.Sessions.TabIndex = 0;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = true;
            // 
            // Add_Session_Room_Btn
            // 
            this.Add_Session_Room_Btn.Location = new System.Drawing.Point(844, 54);
            this.Add_Session_Room_Btn.Name = "Add_Session_Room_Btn";
            this.Add_Session_Room_Btn.Size = new System.Drawing.Size(173, 43);
            this.Add_Session_Room_Btn.TabIndex = 12;
            this.Add_Session_Room_Btn.Text = "Add";
            this.Add_Session_Room_Btn.UseVisualStyleBackColor = true;
            this.Add_Session_Room_Btn.Click += new System.EventHandler(this.Add_Session_Room_Btn_Click);
            // 
            // comboRooms
            // 
            this.comboRooms.FormattingEnabled = true;
            this.comboRooms.Location = new System.Drawing.Point(430, 59);
            this.comboRooms.Name = "comboRooms";
            this.comboRooms.Size = new System.Drawing.Size(360, 35);
            this.comboRooms.TabIndex = 11;
            // 
            // comboSessions
            // 
            this.comboSessions.FormattingEnabled = true;
            this.comboSessions.Location = new System.Drawing.Point(10, 59);
            this.comboSessions.Name = "comboSessions";
            this.comboSessions.Size = new System.Drawing.Size(360, 35);
            this.comboSessions.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Session ID";
            // 
            // SessionRoomAllocationTable
            // 
            this.SessionRoomAllocationTable.AllowUserToAddRows = false;
            this.SessionRoomAllocationTable.AllowUserToDeleteRows = false;
            this.SessionRoomAllocationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionRoomAllocationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sr_id,
            this.sr_lecturer_1,
            this.sr_lecturer_2,
            this.sr_subject,
            this.sr_group,
            this.sr_tag,
            this.sr_room});
            this.SessionRoomAllocationTable.Location = new System.Drawing.Point(10, 130);
            this.SessionRoomAllocationTable.MultiSelect = false;
            this.SessionRoomAllocationTable.Name = "SessionRoomAllocationTable";
            this.SessionRoomAllocationTable.ReadOnly = true;
            this.SessionRoomAllocationTable.RowHeadersWidth = 51;
            this.SessionRoomAllocationTable.RowTemplate.Height = 24;
            this.SessionRoomAllocationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionRoomAllocationTable.Size = new System.Drawing.Size(1007, 599);
            this.SessionRoomAllocationTable.TabIndex = 7;
            // 
            // sr_id
            // 
            this.sr_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_id.HeaderText = "ID";
            this.sr_id.MinimumWidth = 6;
            this.sr_id.Name = "sr_id";
            this.sr_id.ReadOnly = true;
            // 
            // sr_lecturer_1
            // 
            this.sr_lecturer_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_lecturer_1.HeaderText = "Lecturer 1";
            this.sr_lecturer_1.MinimumWidth = 6;
            this.sr_lecturer_1.Name = "sr_lecturer_1";
            this.sr_lecturer_1.ReadOnly = true;
            // 
            // sr_lecturer_2
            // 
            this.sr_lecturer_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_lecturer_2.HeaderText = "Lecturer 2";
            this.sr_lecturer_2.MinimumWidth = 6;
            this.sr_lecturer_2.Name = "sr_lecturer_2";
            this.sr_lecturer_2.ReadOnly = true;
            // 
            // sr_subject
            // 
            this.sr_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_subject.HeaderText = "Subject";
            this.sr_subject.MinimumWidth = 6;
            this.sr_subject.Name = "sr_subject";
            this.sr_subject.ReadOnly = true;
            // 
            // sr_group
            // 
            this.sr_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_group.HeaderText = "Group";
            this.sr_group.MinimumWidth = 6;
            this.sr_group.Name = "sr_group";
            this.sr_group.ReadOnly = true;
            // 
            // sr_tag
            // 
            this.sr_tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_tag.HeaderText = "Tag";
            this.sr_tag.MinimumWidth = 6;
            this.sr_tag.Name = "sr_tag";
            this.sr_tag.ReadOnly = true;
            // 
            // sr_room
            // 
            this.sr_room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_room.HeaderText = "Room";
            this.sr_room.MinimumWidth = 6;
            this.sr_room.Name = "sr_room";
            this.sr_room.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(820, 750);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.natDel);
            this.tabPage4.Controls.Add(this.natAdd);
            this.tabPage4.Controls.Add(this.selectSlot);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.selectDay);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.selectRooms);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.Non_Available_Time_Slot_Table);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1028, 819);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Non Available Time";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // natDel
            // 
            this.natDel.Location = new System.Drawing.Point(608, 104);
            this.natDel.Name = "natDel";
            this.natDel.Size = new System.Drawing.Size(168, 45);
            this.natDel.TabIndex = 8;
            this.natDel.Text = "Delete";
            this.natDel.UseVisualStyleBackColor = true;
            this.natDel.Click += new System.EventHandler(this.natDel_Click);
            // 
            // natAdd
            // 
            this.natAdd.Location = new System.Drawing.Point(433, 104);
            this.natAdd.Name = "natAdd";
            this.natAdd.Size = new System.Drawing.Size(168, 45);
            this.natAdd.TabIndex = 7;
            this.natAdd.Text = "Add";
            this.natAdd.UseVisualStyleBackColor = true;
            this.natAdd.Click += new System.EventHandler(this.natAdd_Click);
            // 
            // selectSlot
            // 
            this.selectSlot.FormattingEnabled = true;
            this.selectSlot.Location = new System.Drawing.Point(433, 38);
            this.selectSlot.Name = "selectSlot";
            this.selectSlot.Size = new System.Drawing.Size(343, 35);
            this.selectSlot.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Time Slot";
            // 
            // selectDay
            // 
            this.selectDay.FormattingEnabled = true;
            this.selectDay.Location = new System.Drawing.Point(25, 114);
            this.selectDay.Name = "selectDay";
            this.selectDay.Size = new System.Drawing.Size(343, 35);
            this.selectDay.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select Day";
            // 
            // selectRooms
            // 
            this.selectRooms.FormattingEnabled = true;
            this.selectRooms.Location = new System.Drawing.Point(25, 38);
            this.selectRooms.Name = "selectRooms";
            this.selectRooms.Size = new System.Drawing.Size(343, 35);
            this.selectRooms.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Room";
            // 
            // Non_Available_Time_Slot_Table
            // 
            this.Non_Available_Time_Slot_Table.AllowUserToAddRows = false;
            this.Non_Available_Time_Slot_Table.AllowUserToDeleteRows = false;
            this.Non_Available_Time_Slot_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Non_Available_Time_Slot_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nat_id,
            this.nat_day,
            this.nat_room,
            this.nat_timeslot});
            this.Non_Available_Time_Slot_Table.Location = new System.Drawing.Point(6, 168);
            this.Non_Available_Time_Slot_Table.MultiSelect = false;
            this.Non_Available_Time_Slot_Table.Name = "Non_Available_Time_Slot_Table";
            this.Non_Available_Time_Slot_Table.ReadOnly = true;
            this.Non_Available_Time_Slot_Table.RowHeadersWidth = 51;
            this.Non_Available_Time_Slot_Table.RowTemplate.Height = 24;
            this.Non_Available_Time_Slot_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Non_Available_Time_Slot_Table.Size = new System.Drawing.Size(1016, 645);
            this.Non_Available_Time_Slot_Table.TabIndex = 0;
            // 
            // nat_id
            // 
            this.nat_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_id.HeaderText = "ID";
            this.nat_id.MinimumWidth = 6;
            this.nat_id.Name = "nat_id";
            this.nat_id.ReadOnly = true;
            // 
            // nat_day
            // 
            this.nat_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_day.HeaderText = "Day";
            this.nat_day.MinimumWidth = 6;
            this.nat_day.Name = "nat_day";
            this.nat_day.ReadOnly = true;
            // 
            // nat_room
            // 
            this.nat_room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_room.HeaderText = "Room";
            this.nat_room.MinimumWidth = 6;
            this.nat_room.Name = "nat_room";
            this.nat_room.ReadOnly = true;
            // 
            // nat_timeslot
            // 
            this.nat_timeslot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nat_timeslot.HeaderText = "Timeslot";
            this.nat_timeslot.MinimumWidth = 6;
            this.nat_timeslot.Name = "nat_timeslot";
            this.nat_timeslot.ReadOnly = true;
            // 
            // Add_Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 929);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Add_Locations";
            this.Text = "Manage Locations";
            this.Load += new System.EventHandler(this.Add_Locations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Sessions.ResumeLayout(false);
            this.Sessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionRoomAllocationTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Non_Available_Time_Slot_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private string connectionString = "server=database-itpm.cmahd6rnztyt.ap-south-1.rds.amazonaws.com;user=root;password=root_toor;database=itpm";
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button inserBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Sessions;
        private System.Windows.Forms.Button Add_Session_Room_Btn;
        private System.Windows.Forms.ComboBox comboRooms;
        private System.Windows.Forms.ComboBox comboSessions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SessionRoomAllocationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_lecturer_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_lecturer_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_room;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Non_Available_Time_Slot_Table;
        private System.Windows.Forms.ComboBox selectDay;
        private System.Windows.Forms.Button natDel;
        private System.Windows.Forms.Button natAdd;
        private System.Windows.Forms.ComboBox selectSlot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn nat_timeslot;
    }
}