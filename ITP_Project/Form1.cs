using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_working_schedule_Click(object sender, EventArgs e)
        {
            add_working_hours_days_window workingHoursWindow = new add_working_hours_days_window();
            workingHoursWindow.ShowDialog();
        }

        private void btn_manage_taglist_Click(object sender, EventArgs e)
        {
            Add_Tags tagWindow = new Add_Tags();
            tagWindow.ShowDialog();
        }

        private void btn_manage_students_Click(object sender, EventArgs e)
        {
            add_student_group addStrudentGroup = new add_student_group();
            addStrudentGroup.ShowDialog();
        }

        private void btn_manage_subjects_Click(object sender, EventArgs e)
        {
            SubjectAdding subjectWindow = new SubjectAdding();
            subjectWindow.ShowDialog();
        }

        private void btn_manage_locations_Click(object sender, EventArgs e)
        {
            Add_Locations locationWindow = new Add_Locations();
            locationWindow.ShowDialog();
        }

        private void btn_manage_lectures_Click(object sender, EventArgs e)
        {
            LectureAdding lectureScreen = new LectureAdding();
            lectureScreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location_Statistics lc = new Location_Statistics();
            lc.ShowDialog();
        }

        private void btn_manage_sessions_Click(object sender, EventArgs e)
        {
            manage_sessions ms = new manage_sessions();
            ms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_Time_Table gtt = new Generate_Time_Table();
            gtt.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Config config = new Config();
                MySqlConnection connect = new MySqlConnection(config.connectionString);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM lectures LIMIT 0,1");
                cmd.Connection = connect;
                connect.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                connect.Close();
            } catch
            {
                MessageBox.Show("Unable to connect the database server. Please check your internet connectivity.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
