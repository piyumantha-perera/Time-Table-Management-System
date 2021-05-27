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
    public partial class manage_sessions : Form
    {

        public manage_sessions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUpdateSession aus = new AddUpdateSession();
            aus.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddUpdateSession aus = new AddUpdateSession();
            aus.ShowDialog();
            this.load_sessions();
        }

        private void manage_sessions_Load(object sender, EventArgs e)
        {
            this.load_sessions();
            this.loadNonAvailableTime();
        }

        private void load_sessions()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessions");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            this.SessionTable.Rows.Clear();
            this.ConsicutiveSessions.Rows.Clear();
            this.Non_Overlapping_Sessions.Rows.Clear();
            this.Parallel_Sessions.Rows.Clear();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.SessionTable);

                row.Cells[0].Value = reader.GetInt32("id");
                row.Cells[1].Value = reader.GetString("lecturer_1");
                row.Cells[2].Value = reader.GetString("lecturer_2");
                row.Cells[3].Value = reader.GetString("subject");
                row.Cells[4].Value = reader.GetString("group");
                row.Cells[5].Value = reader.GetString("tag");
                row.Cells[6].Value = reader.GetInt32("num_of_students");
                row.Cells[7].Value = reader.GetInt32("duration");

                this.SessionTable.Rows.Add(row);

                if (reader.GetInt32("is_consecutive") == 1)
                {

                    row = new DataGridViewRow();
                    row.CreateCells(this.ConsicutiveSessions);
                    row.Cells[0].Value = reader.GetInt32("id");
                    row.Cells[1].Value = reader.GetString("lecturer_1");
                    row.Cells[2].Value = reader.GetString("lecturer_2");
                    row.Cells[3].Value = reader.GetString("subject");
                    row.Cells[4].Value = reader.GetString("group");
                    row.Cells[5].Value = reader.GetString("tag");

                    this.ConsicutiveSessions.Rows.Add(row);
                }

                if (reader.GetInt32("is_parallel") == 1)
                {

                    row = new DataGridViewRow();
                    row.CreateCells(this.Parallel_Sessions);
                    row.Cells[0].Value = reader.GetInt32("id");
                    row.Cells[1].Value = reader.GetString("lecturer_1");
                    row.Cells[2].Value = reader.GetString("lecturer_2");
                    row.Cells[3].Value = reader.GetString("subject");
                    row.Cells[4].Value = reader.GetString("group");
                    row.Cells[5].Value = reader.GetString("tag");

                    this.Parallel_Sessions.Rows.Add(row);
                }

                if (reader.GetInt32("is_overlapping") == 0)
                {

                    row = new DataGridViewRow();
                    row.CreateCells(this.Non_Overlapping_Sessions);
                    row.Cells[0].Value = reader.GetInt32("id");
                    row.Cells[1].Value = reader.GetString("lecturer_1");
                    row.Cells[2].Value = reader.GetString("lecturer_2");
                    row.Cells[3].Value = reader.GetString("subject");
                    row.Cells[4].Value = reader.GetString("group");
                    row.Cells[5].Value = reader.GetString("tag");

                    this.Non_Overlapping_Sessions.Rows.Add(row);
                }
            }


            reader.Close();
            connect.Close();
        }

        private void loadNonAvailableTime()
        {
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM session_non_available_times");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            this.Non_Available_Time_Table.Rows.Clear();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.Non_Available_Time_Table);

                row.Cells[0].Value = reader.GetInt32("id");
                row.Cells[1].Value = reader.GetInt32("session_id");
                row.Cells[2].Value = reader.GetString("lecturer");
                row.Cells[3].Value = reader.GetString("group");
                row.Cells[4].Value = reader.GetString("subgroup");
                row.Cells[5].Value = reader.GetString("day");
                row.Cells[6].Value = reader.GetString("time");

                this.Non_Available_Time_Table.Rows.Add(row);
            }


            reader.Close();
            connect.Close();
        }

        private void search(String hint, String column)
        {
            String condition = null;

            if ( column == "Lecturer")
            {
                condition = " lecturer_1 LIKE '%" + hint + "%' OR lecturer_2 LIKE '%" + column + "%' ";
            } else if ( column == "Subject" )
            {
                condition = " subject LIKE '%" + hint + "%' ";
            } else if ( column == "Group" )
            {
                condition = " group LIKE '%" + hint + "%' ";
            } else if ( column == "Tag" )
            {
                condition = " tag LIKE '%" + hint + "%' ";
            } else
            {
                return;
            }
            //Session database
            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessions WHERE "+condition);
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            this.SessionTable.Rows.Clear();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.SessionTable);

                row.Cells[0].Value = reader.GetInt32("id");
                row.Cells[1].Value = reader.GetString("lecturer_1");
                row.Cells[2].Value = reader.GetString("lecturer_2");
                row.Cells[3].Value = reader.GetString("subject");
                row.Cells[4].Value = reader.GetString("group");
                row.Cells[5].Value = reader.GetString("tag");
                row.Cells[6].Value = reader.GetInt32("num_of_students");
                row.Cells[7].Value = reader.GetInt32("duration");

                this.SessionTable.Rows.Add(row);
            }

            reader.Close();
            connect.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String hint = txtSearchHint.Text;
            String column = comboSearchOption.Text;
            this.search(hint, column);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String recordId = this.SessionTable.CurrentRow.Cells[0].Value.ToString();

            DialogResult dr = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if ( dr == DialogResult.No )
            {
                return;
            }

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM sessions WHERE id = "+recordId);
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.load_sessions();
        }

        private void add_consecutive_session_Click(object sender, EventArgs e)
        {
            Session_Select_Window ssw = new Session_Select_Window("consecutive_sessons");
            ssw.ShowDialog();
            this.load_sessions();
        }

        private void Add_Non_Overlapping_Session_Click(object sender, EventArgs e)
        {
            Session_Select_Window ssw = new Session_Select_Window("overlapping_sessons");
            ssw.ShowDialog();
            this.load_sessions();
        }

        private void Parallel_Manage_Session_Click(object sender, EventArgs e)
        {
            Session_Select_Window ssw = new Session_Select_Window("parallel_sessons");
            ssw.ShowDialog();
            this.load_sessions();
        }

        private void btnAddNATime_Click(object sender, EventArgs e)
        {
            Add_Session_Non_Available_Times addNewScreen = new Add_Session_Non_Available_Times();
            addNewScreen.ShowDialog();
            this.loadNonAvailableTime();
        }

        private void Non_Available_Time_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDeleteNAT_Click(object sender, EventArgs e)
        {

            int id = (int)this.Non_Available_Time_Table.CurrentRow.Cells[0].Value;

            DialogResult dr = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( dr == DialogResult.No )
            {
                return;
            }

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM session_non_available_times WHERE id = " + id);
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.loadNonAvailableTime();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)this.SessionTable.CurrentRow.Cells[0].Value;
            AddUpdateSession aus = new AddUpdateSession(id);
            aus.ShowDialog();
            this.load_sessions();
        }
    }
}
