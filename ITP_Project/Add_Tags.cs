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
    public partial class Add_Tags : Form
    {
        public Add_Tags()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadTags()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tags ORDER BY id");
            cmd.Connection = connect;
            connect.Open();

            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("tag");
                row.Cells[2].Value = dr.GetString("code");
                row.Cells[3].Value = dr.GetString("related_tag");
                this.dataGridView1.Rows.Add(row);
            }

            dr.Close();
            connect.Close();
        }

        private void Add_Tags_Load(object sender, EventArgs e)
        {
            this.loadTags();
        }

        private void tagNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tagCodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void relatedTagtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBtn_tag_Click(object sender, EventArgs e)
        {
            string tag = this.tagNametxt.Text;
            string code = this.tagCodetxt.Text;
            string related_tag = this.relatedTagtxt.Text;

            if (tag == "" || code == "") {
                MessageBox.Show("`Tag` and `Code` are mandatory fields. You cannot leave it as empty.", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tags (id, tag, code, related_tag) VALUES (NULL,'"+tag+"','"+code+"','"+related_tag+"')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Tag has been added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.tagNametxt.Text = "";
            this.tagCodetxt.Text = "";
            this.relatedTagtxt.Text = "";

            this.dataGridView1.Rows.Clear();
            this.loadTags();

        }

        private void updateBtn_tag_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.insertBtn_tag.Enabled = false;
                this.deleteBtn_tag.Enabled = false;
                this.updateBtn_tag.Text = "Save";
                this.clearBtn_tag.Text = "Cancel";
                this.updateMode = true;
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                this.tagNametxt.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.tagCodetxt.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.relatedTagtxt.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

            } else
            {
                string tag = this.tagNametxt.Text;
                string code = this.tagCodetxt.Text;
                string related_tag = this.relatedTagtxt.Text;

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE tags SET tag = '" + tag + "', code = '" + code + "', related_tag = '" + related_tag + "' WHERE id = "+this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Tag has been updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tagNametxt.Text = "";
                this.tagCodetxt.Text = "";
                this.relatedTagtxt.Text = "";

                this.dataGridView1.Rows.Clear();
                this.loadTags();

                this.insertBtn_tag.Enabled = true;
                this.deleteBtn_tag.Enabled = true;
                this.updateBtn_tag.Text = "Update";
                this.clearBtn_tag.Text = "Clear";
                this.updateMode = false;
                this.selectedRecord = null;
            }

            //this.dataGridView1.SelectedRows
        }


        private void clearBtn_tag_Click(object sender, EventArgs e)
        {
            this.selectedRecord = null;
            this.tagNametxt.Text = "";
            this.tagCodetxt.Text = "";
            this.relatedTagtxt.Text = "";
            this.insertBtn_tag.Enabled = true;
            this.deleteBtn_tag.Enabled = true;
            this.updateBtn_tag.Text = "Update";
            this.clearBtn_tag.Text = "Clear";
            this.updateMode = false;
        }


        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void deleteBtn_tag_Click(object sender, EventArgs e)
        {
            this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if ( this.selectedRecord != null )
            {
                string t_tag = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string t_code = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string t_rtag = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Do you want to delete this record?\n" + t_tag + "-" + t_code + "-" + t_rtag, "Are you sure?", MessageBoxButtons.YesNo);

                if ( dialogResult == DialogResult.Yes ) {
                    MySqlConnection connect = new MySqlConnection(this.connectionString);
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tags WHERE id = " + this.selectedRecord);
                    cmd.Connection = connect;
                    connect.Open();
                    cmd.ExecuteReader().Close();
                    connect.Close();
                    this.dataGridView1.Rows.Clear();
                    this.loadTags();
                }

                this.selectedRecord = null;

            } else
            {
                MessageBox.Show("Please select the record that you want to delete.", "No Record Selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
