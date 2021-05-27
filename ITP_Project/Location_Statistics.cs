using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class Location_Statistics : Form
    {
        public Location_Statistics()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void Location_Statistics_Load(object sender, EventArgs e)
        {
            this.loadLectuerCount();
            this.loadLocationCount();
            this.loadStudentCount();
            this.loadSubjectCount();
            this.loadGraphData();
        }

        private void loadLectuerCount()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as count, lecture FROM lectures");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                this.lecturers_count.Text = reader.GetInt32("count").ToString();
                this.Crt_Lectxt.Text = reader.GetString("lecture");
            }

            reader.Close();
            connect.Close();
        }

        private void loadStudentCount()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as count, group_id FROM student_groups");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.students_count.Text = reader.GetInt32("count").ToString();
                this.Cur_Grptxt.Text = reader.GetString("group_id");
            }

            reader.Close();
            connect.Close();
        }

        private void loadSubjectCount()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as count, subject FROM subject");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.subjects_count.Text = reader.GetInt32("count").ToString();
                this.Cur_Modtxt.Text = reader.GetString("subject");
            }

            reader.Close();
            connect.Close();
        }

        private void loadLocationCount()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as count FROM locations");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.locations_count.Text = reader.GetInt32("count").ToString();
            }

            reader.Close();
            connect.Close();
        }

        private void loadGraphData()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as count, type FROM `locations` GROUP BY type");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.chart1.Series.Add(reader.GetString("type"));
                this.chart1.Series[reader.GetString("type")].Points.AddXY("", reader.GetInt32("count"));
            }

            reader.Close();
            connect.Close();
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }
    }
}
