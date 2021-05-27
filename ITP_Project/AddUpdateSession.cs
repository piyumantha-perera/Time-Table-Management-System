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
    public partial class AddUpdateSession : Form
    {
        private int updateId = 0;
        public AddUpdateSession(int updateId = 0)
        {
            InitializeComponent();
            this.updateId = updateId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lecturer1 = null;
            String lecturer2 = null;
            String tag = tags_selector.Text;
            String subject = SubjectSelector.Text;
            String group = GroupSelector.Text;
            decimal noOfStudents = NoOfStudents.Value;
            decimal duration = Duration.Value;

            if ( this.Lecturer_List.SelectedItems.Count == 0 )
            {
                MessageBox.Show("Please select the lecturer.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( tag == "" )
            {
                MessageBox.Show("Please select the tag.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( subject  == "")
            {
                MessageBox.Show("Please select the subject.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( group == "")
            {
                MessageBox.Show("Please select the group.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( noOfStudents <= 0)
            {
                MessageBox.Show("Please enter the valid number of students.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ( duration <= 0)
            {
                MessageBox.Show("Please enter the valid number of hours.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach ( String item in this.Lecturer_List.CheckedItems )
            {
                if (lecturer1 == null) {
                    lecturer1 = item.ToString();
                } else
                {
                    lecturer2 = item.ToString();
                }
            }

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            String sql = "";

            if (this.updateId == 0)
            {
                sql = "INSERT INTO sessions VALUES (" +
                    "NULL," +
                    "'" + lecturer1 + "'," +
                    "'" + lecturer2 + "'," +
                    "'" + subject + "'," +
                    "'" + group + "'," +
                    "'" + tag + "'," +
                    noOfStudents + "," +
                    duration + ",0,1,0" +
                ")";
            } else
            {
                sql = "UPDATE sessions SET " +
                    "lecturer_1 = '" + lecturer1 + "'," +
                    "lecturer_2 = '" + lecturer2 + "'," +
                    "subject = '" + subject + "'," +
                    "`group` = '" + group + "'," +
                    "tag = '" + tag + "'," +
                    "num_of_students = " + noOfStudents + "," +
                    "duration = " + duration + " " +
                    "WHERE id = "+ this.updateId;
            }

            MySqlCommand cmd = new MySqlCommand(sql);

            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Session has been added succussfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void AddUpdateSession_Load(object sender, EventArgs e)
        {
            this.loadLecturers();
            this.loadTags();
            this.loadGroups();
            this.loadSubjects();


            if (updateId != 0)
            {
                this.AddBtn.Text = "Update";
                this.loadRecordDetail();
            }
        }

        private void loadLecturers()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lectures");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Lecturer_List.Items.Add(reader.GetString("lecture"));
            }

            reader.Close();
            connect.Close();
        }

        private void loadTags()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tags");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tags_selector.Items.Add(reader.GetString("tag"));
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
                GroupSelector.Items.Add(reader.GetString("group_id"));
            }

            reader.Close();
            connect.Close();
        }

        private void loadSubjects()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT subject FROM subject ORDER BY subject");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SubjectSelector.Items.Add(reader.GetString("subject"));
            }

            reader.Close();
            connect.Close();
        }

        private void loadRecordDetail()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessions WHERE id = " + this.updateId);
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                for (var i = 0; i < this.Lecturer_List.Items.Count; i++)
                {
                    if ( this.Lecturer_List.Items[i].ToString() == reader.GetString("lecturer_1") || this.Lecturer_List.Items[i].ToString() == reader.GetString("lecturer_2") )
                    {
                        this.Lecturer_List.SetItemChecked(i, true);
                    }
                }

                this.tags_selector.Text = reader.GetString("tag");
                this.GroupSelector.Text = reader.GetString("group");
                this.SubjectSelector.Text = reader.GetString("subject");
                this.NoOfStudents.Text = reader.GetInt32("num_of_students").ToString();
                this.Duration.Text = reader.GetInt32("duration").ToString();

            }

            reader.Close();
            connect.Close();
        }

    }
}
