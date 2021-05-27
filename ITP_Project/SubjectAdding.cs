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
    public partial class SubjectAdding : Form
    {
        public SubjectAdding()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM subject");
            cmd.Connection = connect;
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("year");
                row.Cells[2].Value = dr.GetString("semester");
                row.Cells[3].Value = dr.GetString("subject");
                row.Cells[4].Value = dr.GetString("code");
                row.Cells[5].Value = dr.GetInt64("lecture_hours").ToString();
                row.Cells[6].Value = dr.GetInt64("tutorial_hours").ToString();
                row.Cells[7].Value = dr.GetInt64("lab_hours").ToString();
                row.Cells[8].Value = dr.GetInt64("evaluation_hours").ToString();

                this.dataGridView1.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void SubjectAdding_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string year = this.txtboxYear.Text;
            string sem = this.txtBoxSemester.Text;
            string sub = this.txtBoxSubject.Text;
            string code = this.txtboxSubjectCode.Text;
            string lec = this.txtBoxLectureHours.Text;
            string tut = this.txtBoxTutorialHours.Text;
            string lab = this.txtBoxLabHours.Text;
            string eva = this.txtBoxEvaluationHours.Text;

            if (year == "" || sem == "" || sub == "" || code == "" || lec == "" || tut == "" || lab == "" || eva == "")
            {
                MessageBox.Show("Please fill all fields!", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO subject VALUES (NULL,'"+year+"','"+sem+"','"+sub+"','"+code+"',"+lec+","+tut+","+lab+","+tut+")");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Student group has beed added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.updateMode) {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtboxYear.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtBoxSemester.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtBoxSubject.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtboxSubjectCode.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txtBoxLectureHours.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.txtBoxTutorialHours.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                this.txtBoxLabHours.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                this.txtBoxEvaluationHours.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

                this.btnSave.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnUpdate.Text = "Save";
                this.btnCancel.Text = "Cancel";
                this.updateMode = true;
            } else
            {

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE subject SET year='" + this.txtboxYear.Text + "', semester='" + this.txtBoxSemester.Text + "', subject='" + this.txtBoxSubject.Text + "', code='" + this.txtboxSubjectCode.Text + "', lecture_hours=" + this.txtBoxLectureHours.Text + ", tutorial_hours=" + this.txtBoxTutorialHours.Text + ", lab_hours=" + this.txtBoxLabHours.Text + ", evaluation_hours=" + this.txtBoxEvaluationHours.Text + " WHERE id=" + this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Subject has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel_Click(null, EventArgs.Empty);
                this.loadData();

                this.btnSave.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnUpdate.Text = "Update";
                this.btnCancel.Text = "Clear";
                this.updateMode = false;
                this.selectedRecord = null;
            }
        }

        private Boolean updateMode = false;
        private string selectedRecord = null;
        private string connectionString = "server=database-itpm.cmahd6rnztyt.ap-south-1.rds.amazonaws.com;user=root;password=root_toor;database=itpm";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtboxYear.Text = "";
            this.txtBoxSemester.Text = "";
            this.txtBoxSubject.Text = "";
            this.txtboxSubjectCode.Text = "";
            this.txtBoxLectureHours.Text = "";
            this.txtBoxTutorialHours.Text = "";
            this.txtBoxLabHours.Text = "";
            this.txtBoxEvaluationHours.Text = "";
            this.selectedRecord = null;
            this.updateMode = false;
            this.btnSave.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Text = "Update";
            this.btnCancel.Text = "Clear";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DialogResult dialogR = MessageBox.Show("Do you want to delete subject '" + name + "'?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogR == DialogResult.Yes) {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM subject WHERE id = " + id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();
                MessageBox.Show("Subject has been deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel_Click(null, EventArgs.Empty);
                this.loadData();
            }
        }
    }
}
