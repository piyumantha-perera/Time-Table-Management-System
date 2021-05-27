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
    public partial class add_student_group : Form
    {
        public add_student_group()
        {
            InitializeComponent();
        }

        private void add_student_group_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subGrpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.insertBtn.Enabled = true;
            this.deleteBtn.Enabled = true;
            this.updateBtn.Text = "Update";
            this.clearBtn.Text = "Clear";
            this.updateMode = false;
            this.selectedRecord = null;
            this.semAndYear.Text = "";
            this.programme.Text = "";
            this.grpNum.Text = "";
            this.subGrpNum.Text = "";
            this.grpIdText.Text = "";
            this.SubgrpIdText.Text = "";
        }

        private void semAndYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM student_groups");
            cmd.Connection = connect;
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("year_semester");
                row.Cells[2].Value = dr.GetString("program");
                row.Cells[3].Value = dr.GetInt64("group_no").ToString();
                row.Cells[4].Value = dr.GetInt64("sub_group_no").ToString();
                row.Cells[5].Value = dr.GetString("group_id");
                row.Cells[6].Value = dr.GetString("sub_group_id");

                this.dataGridView1.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void generateIdBtn_Click(object sender, EventArgs e)
        {
            string prefix = this.programme.Text + "." + this.semAndYear.Text + ".";
            this.grpIdText.Text = prefix + this.grpNum.Text;
            this.SubgrpIdText.Text = this.grpIdText.Text + "." + this.subGrpNum.Text;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string year_sem = this.semAndYear.Text;
            string program = this.programme.Text;
            string group_no = this.grpNum.Text;
            string sub_group_no = this.subGrpNum.Text;
            string group_id = this.grpIdText.Text;
            string sub_group_id = this.SubgrpIdText.Text;

            if ( year_sem == "" || program == "" || group_no == "" || sub_group_no == "" || group_id == "" || sub_group_id == "" )
            {
                MessageBox.Show("Please fill all fields!", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO student_groups VALUES (NULL,'"+year_sem+"','"+program+"',"+group_no+","+sub_group_no+",'"+group_id+"','"+sub_group_id+"')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Student group has beed added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.loadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.insertBtn.Enabled = false;
                this.deleteBtn.Enabled = false;
                this.updateBtn.Text = "Save";
                this.clearBtn.Text = "Cancel";
                this.updateMode = true;

                this.semAndYear.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.programme.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.grpNum.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.subGrpNum.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.grpIdText.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.SubgrpIdText.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

            } else
            {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE student_groups SET year_semester='"+ this.semAndYear.Text + "', program='"+ this.programme.Text + "', group_no="+ this.grpNum.Text + ", sub_group_no=" + subGrpNum.Text + ", group_id='"+this.grpIdText.Text+"', sub_group_id='"+ this.SubgrpIdText.Text + "' WHERE id ="+ this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                this.insertBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.updateBtn.Text = "Update";
                this.clearBtn.Text = "Clear";
                this.updateMode = false;
                this.selectedRecord = null;

                MessageBox.Show("Student Group Updated!", "Success!");

                this.button1_Click(null, EventArgs.Empty);
                this.loadData();
            }
        }

        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Do you want to delete this student group?\n"+"'"+name+"'", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM student_groups WHERE id="+id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();
                MessageBox.Show("Student group has been deleted!", "Record Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();
            }
        }
    }
}
