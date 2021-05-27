using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP_Project
{
    public partial class add_working_hours_days_window : Form
    {
        public add_working_hours_days_window()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            ArrayList days = new ArrayList();
            CheckedListBox.CheckedItemCollection workingDays = this.checkedListBox1.CheckedItems;
            
            foreach ( Object item in workingDays )
            {
                days.Add("'"+item.ToString().ToLower()+"'");
            }

            string sql = "UPDATE working_days SET isWorkingDay=1 WHERE day IN ("+string.Join(",",days.Cast<string>().ToArray())+")";
            string iSql = "UPDATE working_days SET isWorkingDay=0 WHERE day NOT IN ("+string.Join(",",days.Cast<string>().ToArray())+")";
            string ijSql = "UPDATE config SET working_days="+this.number_of_working_days.Value.ToString()+ ",working_hours=" + this.working_hours.Value.ToString() + ",working_minutes=" + this.working_minutes.Value.ToString();

            MySqlCommand cmd = new MySqlCommand(sql);
            MySqlCommand iCmd = new MySqlCommand(iSql);
            MySqlCommand ijCmd = new MySqlCommand(ijSql);
            cmd.Connection = connect;
            iCmd.Connection = connect;
            ijCmd.Connection = connect;

            connect.Open();

            cmd.ExecuteReader().Close();
            iCmd.ExecuteReader().Close();
            ijCmd.ExecuteReader().Close();

            MessageBox.Show("Working Days & Hours Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connect.Close();

        }

        private void workingDaysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void loadTimeSlots()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM timeslots");
            cmd.Connection = connect;
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            this.dataGridView1.Rows.Clear();

            while (dr.Read()) {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = dr.GetInt64("id").ToString();
                row.Cells[1].Value = dr.GetString("time_slot").ToString();
                row.Cells[2].Value = dr.GetString("from_time").ToString();
                row.Cells[3].Value = dr.GetString("to_time").ToString();

                this.dataGridView1.Rows.Add(row);
            
            }
            dr.Close();
            connect.Close();
        }

        private void loadConfig()
        {
            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM config");
            cmd.Connection = connect;
            connect.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.number_of_working_days.Value = dr.GetInt64("working_days");
                this.working_hours.Value = dr.GetInt64("working_hours");
                this.working_minutes.Value = dr.GetInt64("working_minutes");

            }
            dr.Close();
            connect.Close();
        }

        private void add_working_hours_days_window_Load(object sender, EventArgs e)
        {
            this.loadConfig();
            this.loadTimeSlots();
            this.checkItems();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string timeSlot = this.txtSlot.Text;
            string timeFrom = this.txtFrom.Value.ToString("H:m:s");
            string timeTo = this.txtTo.Value.ToString("H:m:s");

            if (timeSlot == "" || timeFrom == "" || timeTo == "") {
                MessageBox.Show("Fields cannot be empty!", "Invaid Data.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connect = new MySqlConnection(this.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO timeslots VALUES (NULL, '"+timeSlot+"','"+timeFrom+"','"+timeTo+"')");
            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteReader().Close();
            connect.Close();

            MessageBox.Show("Time slot has been added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.loadTimeSlots();
            this.btnClear_Click(null, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.selectedRecord = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtSlot.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtFrom.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                this.txtTo.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());

                this.btnCreate.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnUpdate.Text = "Save";
                this.btnClear.Text = "Cancel";
                this.updateMode = true;
            }
            else {

                string timeSlot = this.txtSlot.Text;
                string timeFrom = this.txtFrom.Value.ToString("H:m:s");
                string timeTo = this.txtTo.Value.ToString("H:m:s");

                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("UPDATE timeslots SET time_slot = '"+timeSlot+"', from_time = '"+timeFrom+"', to_time = '"+timeTo+"' WHERE id = "+this.selectedRecord);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Time slot has been updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.loadTimeSlots();
                this.btnClear_Click(null, EventArgs.Empty);

                this.btnCreate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnUpdate.Text = "Update";
                this.btnClear.Text = "Clear";
                this.updateMode = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string slot = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogR = MessageBox.Show("Do you want delete the time slot '" + slot + "' ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogR == DialogResult.Yes) {
                MySqlConnection connect = new MySqlConnection(this.connectionString);
                MySqlCommand cmd = new MySqlCommand("DELETE FROM timeslots WHERE id="+id);
                cmd.Connection = connect;
                connect.Open();
                cmd.ExecuteReader().Close();
                connect.Close();

                MessageBox.Show("Time slot has been deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.loadTimeSlots();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSlot.Text = "";
            this.txtFrom.Text = "";
            this.txtTo.Text = "";
            this.btnCreate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Text = "Update";
            this.btnClear.Text = "Clear";
            this.updateMode = false;
            this.selectedRecord = null;
        }

        private Boolean updateMode = false;
        private string selectedRecord = null;

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.number_of_working_days.Value = this.checkedListBox1.CheckedItems.Count;
        }
    }
}
