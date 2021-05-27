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
    public partial class LectureAdding : Form
    {
        public LectureAdding()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadData() {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lectures ORDER BY id");
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
                row.Cells[1].Value = dr.GetString("lecture");
                row.Cells[2].Value = dr.GetString("center");
                row.Cells[3].Value = dr.GetString("building");
                row.Cells[4].Value = dr.GetString("faculty");
                row.Cells[5].Value = dr.GetString("level");
                row.Cells[6].Value = dr.GetString("department");
                row.Cells[7].Value = dr.GetString("level") + "." + dr.GetInt64("id").ToString();
                this.dataGridView1.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void LectureAdding_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clear() {
            this.empId.Text = "";
            this.lectureName.Text = "";
            this.center.Text = "";
            this.building.Text = "";
            this.faculty.Text = "";
            this.level.Text = "";
            this.rank.Text = "";
            this.department.Text = "";
            this.updateMode = false;
            this.selectedRecord = null;
            this.btnUpdate.Text = "UPDATE";
            this.btnClear.Text = "CLEAR";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string lecture = this.lectureName.Text;
            string center = this.center.Text;
            string building = this.building.Text;
            string faculty = this.faculty.Text;
            string level = this.level.Text;
            string department = this.department.Text;

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO lectures VALUES (NULL,'"+lecture+"','"+center+"','"+building+"','"+faculty+"','"+level+"','"+department+"', '')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            this.loadData();
            this.clear();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                this.empId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.lectureName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.center.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.building.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.faculty.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.level.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.department.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                this.rank.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

                this.btnInsert.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnUpdate.Text = "SAVE";
                this.btnClear.Text = "CANCEL";
                this.updateMode = true;
            }
            else {

                string lecture = this.lectureName.Text;
                string center = this.center.Text;
                string building = this.building.Text;
                string faculty = this.faculty.Text;
                string level = this.level.Text;
                string department = this.department.Text;

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE lectures SET lecture='"+lecture+"', center='"+center+"', building='"+building+"', faculty='"+faculty+"', level='"+level+"', department='"+department+"' WHERE id="+this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                this.loadData();
                this.clear();


                this.selectedRecord = null;
                this.btnInsert.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnUpdate.Text = "UPDATE";
                this.btnClear.Text = "CLEAR";
                this.updateMode = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }


        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = this.empId.Text;
            string level = this.level.Text;

            if (id != "" && level != "") {
                this.rank.Text = level + "." + id;
            }
        }


        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DialogResult dialogR = MessageBox.Show("Do you want to delete this lecture '"+name+"' ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(dialogR == DialogResult.Yes)
            {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM lectures WHERE id="+id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();
                this.clear();
                this.loadData();
            }
        }
    }
}
