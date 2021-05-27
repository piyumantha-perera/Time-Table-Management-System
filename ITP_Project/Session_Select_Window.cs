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
    public partial class Session_Select_Window : Form
    {
        public String produces = null;

        public Session_Select_Window(String produceType)
        {
            InitializeComponent();
            this.produces = produceType;
        }

        private void Session_Select_Window_Load(object sender, EventArgs e)
        {
            this.load_sessions();
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

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.SessionTable);

                if (this.produces == "consecutive_sessons" && reader.GetInt32("is_consecutive") == 1)
                {
                    row.Cells[0].Value = true;
                }
                else if (this.produces == "overlapping_sessons" && reader.GetInt32("is_overlapping") == 0)
                {
                    row.Cells[0].Value = true;
                }
                else if (this.produces == "parallel_sessons" && reader.GetInt32("is_parallel") == 1)
                {
                    row.Cells[0].Value = true;
                }
                else
                {
                    row.Cells[0].Value = false;
                }

                row.Cells[1].Value = reader.GetInt32("id");
                row.Cells[2].Value = reader.GetString("lecturer_1");
                row.Cells[3].Value = reader.GetString("lecturer_2");
                row.Cells[4].Value = reader.GetString("subject");
                row.Cells[5].Value = reader.GetString("group");
                row.Cells[6].Value = reader.GetString("tag");

                this.SessionTable.Rows.Add(row);
            }


            reader.Close();
            connect.Close();
        }

        private void SessionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }

            String status = this.SessionTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            int currentStatus = 0;

            if (status == "True")
            {
                this.SessionTable.Rows[e.RowIndex].Cells[0].Value = false;
                currentStatus = 0;
            }
            else
            {
                this.SessionTable.Rows[e.RowIndex].Cells[0].Value = true;
                currentStatus = 1;
            }

            String id = this.SessionTable.Rows[e.RowIndex].Cells[1].Value.ToString();

            Config config = new Config();
            MySqlConnection connect = new MySqlConnection(config.connectionString);

            String sql = null;

            if (this.produces == "consecutive_sessons")
            {
                sql = "UPDATE sessions SET is_consecutive = " + currentStatus + " WHERE id = " + id;
            } else if (this.produces == "overlapping_sessons")
            {
                sql = "UPDATE sessions SET is_overlapping = " + ((currentStatus == 1) ? 0 : 1) + " WHERE id = " + id;
            } else if (this.produces == "parallel_sessons")
            {
                sql = "UPDATE sessions SET is_parallel = " + currentStatus + " WHERE id = " + id;
            } else
            {
                return;
            }

            MySqlCommand cmd = new MySqlCommand(sql);

            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();
        }
    }
}
