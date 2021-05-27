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
    public partial class Add_Session_Non_Available_Times : Form
    {
        public Add_Session_Non_Available_Times()
        {
            InitializeComponent();
        }

        private void Add_Session_Non_Available_Times_Load(object sender, EventArgs e)
        {
            this.loadLecturers();
            this.loadGroups();
            this.loadSubGroups();
            this.loadSessions();
        }

        private void loadLecturers()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lectures");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboLecturer.Items.Add(reader.GetString("lecture"));
            }

            reader.Close();
            connect.Close();
        }
       

        private void loadGroups()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT(group_id) FROM student_groups");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboGroup.Items.Add(reader.GetString("group_id"));
            }

            reader.Close();
            connect.Close();
        }

        private void loadSubGroups()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT sub_group_id FROM student_groups");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboSubGroup.Items.Add(reader.GetString("sub_group_id"));
            }

            reader.Close();
            connect.Close();
        }

        private void loadSessions()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessions");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboSession.Items.Add(reader.GetString("id"));
            }

            reader.Close();
            connect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            String errorMsg = null;

            if ( comboLecturer.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the lecturer.";
            } else if ( comboGroup.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the group.";
            } else if ( comboSubGroup.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the sub group.";
            } else if ( comboSession.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the session.";
            } else if ( comboDay.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the day.";
            } else if ( dateTime.Text == "" )
            {
                isValid = false;
                errorMsg = "Please select the time.";
            }

            if ( !isValid )
            {
                MessageBox.Show(errorMsg, "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO session_non_available_times VALUES (" +
                "NULL,'" + comboLecturer.Text + "'," +
                "'" + comboGroup.Text + "'," +
                "'" + comboSubGroup.Text + "'," +
                comboSession.Text + "," +
                "'" + comboDay.Text + "'," +
                "'" + dateTime.Text + "'" +
            ")");
            cmd.Connection = connect;
            connect.Open();

            cmd.ExecuteReader().Close();
            connect.Close();
            this.Close();
        }
    }
}
