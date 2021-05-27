using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace ITP_Project
{
    public partial class Add_Locations : Form
    {
        public Add_Locations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtBuilding.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtRoom.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.roomType.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtCapacity.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.inserBtn.Enabled = false;
                this.deleteBtn.Enabled = false;
                this.Updatebtn.Text = "Save";
                this.Clearbtn.Text = "Cancel";
                this.updateMode = true;
            }
            else {

                string building = this.txtBuilding.Text;
                string room = this.txtRoom.Text;
                string type = this.roomType.Text;
                string capacity = this.txtCapacity.Text;

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE locations SET building = '"+ building + "', room = '"+room+"', type = '"+type+"', capacity = '"+capacity+"' WHERE id = "+this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Location has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();


                this.inserBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.Updatebtn.Text = "Update";
                this.Clearbtn.Text = "Clear";
                this.updateMode = true;
                this.selectedRecord = null;

                this.Clearbtn_Click(null, EventArgs.Empty);
            }
        }

        private void loadData()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM locations ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("building");
                row.Cells[2].Value = dr.GetString("room");
                row.Cells[3].Value = dr.GetString("type");
                row.Cells[4].Value = dr.GetString("capacity");
                this.dataGridView1.Rows.Add(row);

                this.comboRooms.Items.Add(dr.GetString("room"));
                this.selectRooms.Items.Add(dr.GetString("room"));
            }

            dr.Close();
            connect.Close();
        }

        private void loadDays()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM working_days WHERE isWorkingDay = 1");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.selectDay.Items.Add(dr.GetString("day"));
            }

            dr.Close();
            connect.Close();
        }

        private void Add_Locations_Load(object sender, EventArgs e)
        {
            this.loadData();
            this.Load_Sessions();
            this.Load_Session_Allocations();
            this.loadDays();
            this.Load_Time_Slots();
            this.Load_Non_Available_Time();
        }

        private void Load_Time_Slots()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM timeslots");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime dt_from = DateTime.ParseExact(reader.GetString("from_time"), "HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dt_to = DateTime.ParseExact(reader.GetString("to_time"), "HH:mm:ss", CultureInfo.InvariantCulture);
                String slot = dt_from.ToString("hh:mm tt", CultureInfo.InvariantCulture) + " - " + dt_to.ToString("hh:mm tt", CultureInfo.InvariantCulture);

                this.selectSlot.Items.Add(slot);
            }

            reader.Close();
        }

        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.txtBuilding.Text = "";
            this.txtRoom.Text = "";
            this.roomType.Text = "";
            this.txtCapacity.Text = "";
            this.selectedRecord = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Do you want to delete location '" + name + "'", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM locations WHERE id = "+id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Location has been removed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();
            }
        }

        private void Load_Session_Allocations()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT sr.id as record_id, sr.room as room, s.* FROM session_rooms sr INNER JOIN sessions s ON s.id = sr.session_id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            this.SessionRoomAllocationTable.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.SessionRoomAllocationTable);

                row.Cells[0].Value = dr.GetInt32("record_id");
                row.Cells[1].Value = dr.GetString("lecturer_1");
                row.Cells[2].Value = dr.GetString("lecturer_2");
                row.Cells[3].Value = dr.GetString("subject");
                row.Cells[4].Value = dr.GetString("group");
                row.Cells[5].Value = dr.GetString("tag");
                row.Cells[6].Value = dr.GetString("room");

                this.SessionRoomAllocationTable.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void Load_Sessions()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessions ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.comboSessions.Items.Add(dr.GetInt32("id"));
            }

            dr.Close();
            connect.Close();
        }

        private void Add_Session_Room_Btn_Click(object sender, EventArgs e)
        {
            String sessionId = this.comboSessions.Text;
            String room = this.comboRooms.Text;

            if ( sessionId == "" || room  == "" )
            {
                MessageBox.Show("Please select session and room!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO session_rooms VALUES (NULL, "+ sessionId + ", '" + room + "')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.comboSessions.Text = "";
            this.comboRooms.Text = "";

            this.Load_Session_Allocations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String currectRecordId = this.SessionRoomAllocationTable.CurrentRow.Cells[0].Value.ToString();

            DialogResult dr = MessageBox.Show("Do you want to remove this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( dr != DialogResult.Yes )
            {
                return;
            } 

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM session_rooms WHERE id = " + currectRecordId);
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.Load_Session_Allocations();
        }

        private void Load_Non_Available_Time()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM room_non_available_time");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            this.Non_Available_Time_Slot_Table.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.Non_Available_Time_Slot_Table);

                row.Cells[0].Value = dr.GetInt32("id");
                row.Cells[1].Value = dr.GetString("day");
                row.Cells[2].Value = dr.GetString("room");
                row.Cells[3].Value = dr.GetString("timeslot");

                this.Non_Available_Time_Slot_Table.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void natAdd_Click(object sender, EventArgs e)
        {
            string room = this.selectRooms.Text;
            string day = this.selectDay.Text;
            string timeSlots = this.selectSlot.Text;

            if ( room == "" || day == "" || timeSlots == "")
            {
                MessageBox.Show("Please select Room, Day and Timeslot.", "Invalid!");
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO room_non_available_time VALUES (NULL, '"+ room +"', '"+ day +"', '"+ timeSlots + "')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.selectRooms.Text = "";
            this.selectDay.Text = "";
            this.selectSlot.Text = "";

            this.Load_Non_Available_Time();
        }

        private void natDel_Click(object sender, EventArgs e)
        {

            String id = this.Non_Available_Time_Slot_Table.CurrentRow.Cells[0].Value.ToString();

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM room_non_available_time WHERE id = " + id);
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.Load_Non_Available_Time();
        }

        private void inserBtn_Click(object sender, EventArgs e)
        {
            string building = this.txtBuilding.Text;
            string room = this.txtRoom.Text;
            string type = this.roomType.Text;
            string capacity = this.txtCapacity.Text;

            if (building == "" || room == "" || type == "" || capacity == "")
            {
                MessageBox.Show("You need to fill all fields.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO locations VALUES (NULL,'" + building + "','" + room + "','" + type + "','" + capacity + "')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Location has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.loadData();

            this.Clearbtn_Click(null, EventArgs.Empty);
        }
    }
}
