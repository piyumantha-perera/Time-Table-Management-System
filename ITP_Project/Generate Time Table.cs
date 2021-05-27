using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class Generate_Time_Table : Form
    {
        private List<String> timeSlots = new List<String>();
        private List<int> workingDays = new List<int>();

        public Generate_Time_Table()
        {
            InitializeComponent();
        }

        private void Generate_Time_Table_Load(object sender, EventArgs e)
        {
            this.Load_Time_Slots();
            this.loadWorkingDays();
            this.Load_Lecturers();
            this.Load_Student_Groups();
            this.Load_Locations();
        }

        private void Load_Locations()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM locations ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.selectRoom.Items.Add(dr.GetString("room"));
            }

            dr.Close();
            connect.Close();
        }

        private void Load_Student_Groups()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM student_groups ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.SelectStudent.Items.Add(dr.GetString("group_id"));
            }

            dr.Close();
            connect.Close();
        }

        private void Generate_Lecturer_TimeTable() {

            var subjects = new List<string>();
            var assignedSubjects = new List<string>();
            var lecturer = this.selectLecturer.Text;

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT s.*, sr.room FROM sessions s INNER JOIN session_rooms sr ON sr.session_id = s.id WHERE s.lecturer_1 = '"+lecturer+"' OR s.lecturer_2 = '"+lecturer+"'");
            cmd.Connection = connect;
            connect.Open();
           
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var subjectDetail = lecturer + ", " + reader.GetString("subject") + ", " + reader.GetString("tag") + ", " + reader.GetString("group") + ", " + reader.GetString("room");
                subjects.Add(subjectDetail);
            }

            if (subjects.Count == 0)
            {
                MessageBox.Show("No Sessions Found. Please check sessions are assigned to rooms", "No Sessions.");
            }

            foreach (int workingDay in this.workingDays) {
                foreach (string subject in subjects)
                {
                    bool isExists = assignedSubjects.Any(x => x.Contains(subject));

                    if ( !isExists )
                    {
                        for (var i = 0; i < this.timeSlots.Count; i++) {
                            if (this.lecturer_timetable.Rows[i].Cells[workingDay].Value == null || this.lecturer_timetable.Rows[i].Cells[workingDay].Value.ToString() == "--") {
                                this.lecturer_timetable.Rows[i].Cells[workingDay].Value = subject;
                                assignedSubjects.Add(subject);
                                break;
                            }

                            continue;
                        }
                    }

                    continue;
                }
            }

            reader.Close();
            connect.Close();

        }

        private void Generate_Rooms_TimeTable()
        {

            var subjects = new List<string>();
            var assignedSubjects = new List<string>();
            var room = this.selectRoom.Text;

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT s.*, sr.room FROM sessions s INNER JOIN session_rooms sr ON sr.session_id = s.id WHERE sr.room = '" + room + "'");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var subjectDetail = reader.GetString("lecturer_1") + ", " + reader.GetString("subject") + ", " + reader.GetString("tag") + ", " + reader.GetString("group") + ", " + reader.GetString("room");
                subjects.Add(subjectDetail);
            }

            if (subjects.Count == 0)
            {
                MessageBox.Show("No Sessions Found. Please check sessions are assigned to rooms", "No Sessions.");
            }

            foreach (int workingDay in this.workingDays)
            {
                foreach (string subject in subjects)
                {
                    bool isExists = assignedSubjects.Any(x => x.Contains(subject));

                    if (!isExists)
                    {
                        for (var i = 0; i < this.timeSlots.Count; i++)
                        {
                            if (this.locationTimeTable.Rows[i].Cells[workingDay].Value == null || this.locationTimeTable.Rows[i].Cells[workingDay].Value.ToString() == "--")
                            {
                                this.locationTimeTable.Rows[i].Cells[workingDay].Value = subject;
                                assignedSubjects.Add(subject);
                                break;
                            }

                            continue;
                        }
                    }

                    continue;
                }
            }

            reader.Close();
            connect.Close();

        }

        private void Generate_Group_TimeTable()
        {

            var subjects = new List<string>();
            var assignedSubjects = new List<string>();
            var group = this.SelectStudent.Text;

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT s.*, sr.room FROM sessions s INNER JOIN session_rooms sr ON sr.session_id = s.id WHERE s.group_id = '" + group + "'");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var subjectDetail = reader.GetString("lecturer_1") + ", " + reader.GetString("subject") + ", " + reader.GetString("tag") + ", " + reader.GetString("group") + ", " + reader.GetString("room");
                subjects.Add(subjectDetail);
            }

            if (subjects.Count == 0)
            {
                MessageBox.Show("No Sessions Found. Please check sessions are assigned to rooms", "No Sessions.");
            }

            foreach (int workingDay in this.workingDays)
            {
                foreach (string subject in subjects)
                {
                    bool isExists = assignedSubjects.Any(x => x.Contains(subject));

                    if (!isExists)
                    {
                        for (var i = 0; i < this.timeSlots.Count; i++)
                        {
                            if (this.StudentTimeTable.Rows[i].Cells[workingDay].Value == null || this.StudentTimeTable.Rows[i].Cells[workingDay].Value.ToString() == "--")
                            {
                                this.StudentTimeTable.Rows[i].Cells[workingDay].Value = subject;
                                assignedSubjects.Add(subject);
                                break;
                            }

                            continue;
                        }
                    }

                    continue;
                }
            }

            reader.Close();
            connect.Close();

        }

        private void loadWorkingDays()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM working_days WHERE isWorkingDay = 1");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.workingDays.Add(reader.GetInt32("id"));
            }

            reader.Close();
            connect.Close();
        }

        private void Load_Lecturers()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lectures");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.selectLecturer.Items.Add(reader.GetString("lecture"));
            }

            reader.Close();
            connect.Close();
        }

        private void Load_Time_Slots()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM timeslots");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            this.lecturer_timetable.Rows.Clear();
            this.StudentTimeTable.Rows.Clear();
            this.locationTimeTable .Rows.Clear();

            while (reader.Read())
            {
                DateTime dt_from = DateTime.ParseExact(reader.GetString("from_time"), "HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dt_to = DateTime.ParseExact(reader.GetString("to_time"), "HH:mm:ss", CultureInfo.InvariantCulture);
                String slot = dt_from.ToString("hh:mm tt", CultureInfo.InvariantCulture) + " - " + dt_to.ToString("hh:mm tt", CultureInfo.InvariantCulture);

                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(this.lecturer_timetable);
                row.Cells[0].Value = slot;
                row.Cells[1].Value = "--";
                row.Cells[2].Value = "--";
                row.Cells[3].Value = "--";
                row.Cells[4].Value = "--";
                row.Cells[5].Value = "--";
                row.Cells[6].Value = "--";
                row.Cells[7].Value = "--";
                this.lecturer_timetable.Rows.Add(row);

                row = new DataGridViewRow();
                row.CreateCells(this.StudentTimeTable);
                row.Cells[0].Value = slot;
                row.Cells[1].Value = "--";
                row.Cells[2].Value = "--";
                row.Cells[3].Value = "--";
                row.Cells[4].Value = "--";
                row.Cells[5].Value = "--";
                row.Cells[6].Value = "--";
                row.Cells[7].Value = "--";
                this.StudentTimeTable.Rows.Add(row);

                row = new DataGridViewRow();
                row.CreateCells(this.locationTimeTable);
                row.Cells[0].Value = slot;
                row.Cells[1].Value = "--";
                row.Cells[2].Value = "--";
                row.Cells[3].Value = "--";
                row.Cells[4].Value = "--";
                row.Cells[5].Value = "--";
                row.Cells[6].Value = "--";
                row.Cells[7].Value = "--";
                this.locationTimeTable.Rows.Add(row);

                this.timeSlots.Add(slot);
            }

            reader.Close();
        }

        private void lecturer_generate_Click(object sender, EventArgs e)
        {
            this.Load_Time_Slots();
            this.Generate_Lecturer_TimeTable();
        }

        private void lecturer_print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.lecturer_timetable.Width, this.lecturer_timetable.Height);
            lecturer_timetable.DrawToBitmap(bm, new Rectangle(0, 0, this.lecturer_timetable.Width, this.lecturer_timetable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void studentGenerate_Click(object sender, EventArgs e)
        {
            this.Load_Time_Slots();
            this.Generate_Rooms_TimeTable();
        }

        private void locationGenerate_Click(object sender, EventArgs e)
        {
            this.Load_Time_Slots();
            this.Generate_Rooms_TimeTable();
        }

        private void studentPrint_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }

        private void locationPrint_Click(object sender, EventArgs e)
        {
            printDocument3.Print();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.StudentTimeTable.Width, this.StudentTimeTable.Height);
            StudentTimeTable.DrawToBitmap(bm, new Rectangle(0, 0, this.StudentTimeTable.Width, this.StudentTimeTable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.locationTimeTable.Width, this.locationTimeTable.Height);
            locationTimeTable.DrawToBitmap(bm, new Rectangle(0, 0, this.locationTimeTable.Width, this.locationTimeTable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
