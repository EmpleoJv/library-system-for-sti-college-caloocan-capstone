using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lisen
{
    public partial class registeredModule : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database

        public static int convertedId;
        public registeredModule()
        {
            InitializeComponent();
        }

        private void registeredModule_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM registered where level = 'student'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                registeredStuGridData.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Show Database");
            }

            try
            {
                string query = "SELECT * FROM studentavailable Where studentno != 'admin'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataAvail.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Show Database");
            }
        }

        //private void backBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var adminDashboard = new adminDashboard();
        //    adminDashboard.Closed += (s, args) => this.Close();
        //    adminDashboard.Show();
        //}

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM registered where level = 'student'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                registeredStuGridData.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Refresh Inventory");
            }

            try
            {
                string query = "SELECT * FROM studentavailable Where studentno != 'admin'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataAvail.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Refresh Inventory");

            }
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM registered WHERE studentno LIKE'" +
                    this.searchData.Text + "%' OR username LIKE'" +
                    this.searchData.Text + "%' OR password LIKE'" +
                    this.searchData.Text + "%' OR firstname LIKE'" +
                    this.searchData.Text + "%' OR lastname LIKE'" +
                    this.searchData.Text + "%' OR course LIKE'" +
                    this.searchData.Text + "%' OR section LIKE'" +
                    this.searchData.Text + "%' OR email LIKE'" +
                    this.searchData.Text + "%' OR date LIKE'" +
                    this.searchData.Text + "%'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                registeredStuGridData.DataSource = dt;
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Something Went Wrong!");
            }

        }

        private void registeredStudentCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.registeredStuGridData.Rows[e.RowIndex];
                idTxb.Text = row.Cells[0].Value.ToString();
                studentTxb.Text = row.Cells[1].Value.ToString();
                levelTxb.Text = row.Cells[2].Value.ToString();
                usernameTxb.Text = row.Cells[3].Value.ToString();
                passwordTxb.Text = row.Cells[4].Value.ToString();
                firstnameTxb.Text = row.Cells[5].Value.ToString();
                lastnameTxb.Text = row.Cells[6].Value.ToString();
                courseTxb.Text = row.Cells[7].Value.ToString();
                sectionTxb.Text = row.Cells[8].Value.ToString();
                emailTxb.Text = row.Cells[9].Value.ToString();

            }
        }

        private void cellAvailClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataAvail.Rows[e.RowIndex];
                stuAvailTxb.Text = row.Cells[0].Value.ToString();
            }
        }

        //private void updateBtn_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(idTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(idTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(studentTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(studentTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(levelTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(levelTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(usernameTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(usernameTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(passwordTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(passwordTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(emailTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(emailTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(firstnameTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(firstnameTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(lastnameTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(lastnameTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(courseTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(courseTxb, "Required Input");
        //        return;
        //    }
        //    else if (string.IsNullOrEmpty(sectionTxb.Text.Trim())) // required input for Student No.
        //    {
        //        errorIfEmpty.SetError(sectionTxb, "Required Input");
        //        return;
        //    }

        //    try
        //    {
        //        string query = "UPDATE registered SET username = '" + this.usernameTxb.Text + "', password = '" + this.passwordTxb.Text + "', course = '" + this.courseTxb.Text + "', section = '" + this.sectionTxb.Text + "' WHERE id = '" + this.idTxb.Text + "';"; // SQL query


        //        MySqlConnection conn = new MySqlConnection(conString);
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        MySqlDataReader dr;
        //        conn.Open();
        //        dr = cmd.ExecuteReader();
        //        MessageBox.Show("Succefully Update!");
        //        conn.Close();

        //        idTxb.Text = "";
        //        studentTxb.Text = "";
        //        levelTxb.Text = "";
        //        usernameTxb.Text = "";
        //        passwordTxb.Text = "";
        //        firstnameTxb.Text = "";
        //        lastnameTxb.Text = "";
        //        courseTxb.Text = "";
        //        sectionTxb.Text = "";
        //        emailTxb.Text = "";

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Invalid Input");

        //        idTxb.Text = "";
        //        studentTxb.Text = "";
        //        levelTxb.Text = "";
        //        usernameTxb.Text = "";
        //        passwordTxb.Text = "";
        //        firstnameTxb.Text = "";
        //        lastnameTxb.Text = "";
        //        courseTxb.Text = "";
        //        sectionTxb.Text = "";
        //        emailTxb.Text = "";

        //    }
        //}

        private void deleteRegStuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM registered WHERE id = '" + this.idTxb.Text + "';";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Delete Succefully!");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("The Student you're trying to delete has a borrowed a book, \n deleting cannot proceed!");

            }


        }

        private void addAvailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into studentavailable (studentno) values('" + this.stuAvailTxb.Text + "');";

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                conn.Close();
                MessageBox.Show("Adding SUCCESS!!!");
            }
            catch
            {
                MessageBox.Show("Adding FAILED");
            }
        }

        private void deleteAvailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM studentavailable WHERE studentno = '" + this.stuAvailTxb.Text + "';";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Delete Succefully!");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("The Student is Registered!");

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTxb.Text = "";
            studentTxb.Text = "";
            levelTxb.Text = "";
            usernameTxb.Text = "";
            passwordTxb.Text = "";
            firstnameTxb.Text = "";
            lastnameTxb.Text = "";
            courseTxb.Text = "";
            sectionTxb.Text = "";
            emailTxb.Text = "";
            stuAvailTxb.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminDashboard = new adminDashboard();
            adminDashboard.Closed += (s, args) => this.Close();
            adminDashboard.Show();
        }
    }
}
