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

namespace lisen
{
    public partial class returnBooksModule : Form
    {
        public static string studentNumFromSpecificBorrower;
        public static string stud;
        public static string studEmail;


        public static string borrowingCode;
        public static string bookIdFromDatabase;
        public returnBooksModule()
        {
            InitializeComponent();
        }
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database



        private void returnBooksModule_Load(object sender, EventArgs e)
        {
            //stud = temporaryDatabase.studentNum;
        }
        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            //borrowDataView.Rows.Clear();
            //borrowDataView.Refresh();
            string userFromTempoData = temporaryDatabase.user;
            string passFromTempoData = temporaryDatabase.pass;

            string query = "SELECT studentno, email FROM registered WHERE username ='" + userFromTempoData + "' AND password = '" + passFromTempoData + "';"; // SQL query 

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand commandata = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandata.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stud = reader.GetString("studentno");
                        studEmail = reader.GetString("email");
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input! Please try again");
            }
            conn.Close();

            string querys = "select * from borrow Where status = '" + "Pending" + "' and studentno = '"+ stud + "';";
            MySqlConnection conns = new MySqlConnection(conString);
            MySqlCommand cmds = new MySqlCommand(querys, conns);
            MySqlDataReader myReaders;

            try
            {
                conns.Open();
                myReaders = cmds.ExecuteReader();

                while (myReaders.Read())
                {
                    string studentno = myReaders.GetString("studentno");
                    string email = myReaders.GetString("email");
                    string bookname = myReaders.GetString("bookname");
                    string status = myReaders.GetString("status");
                    string date = myReaders.GetString("date");
                    string duedate = myReaders.GetString("duedate");

                    borrowDataView.Rows.Add(studentno, email, bookname, status, date, duedate);
                }
            }
            catch
            {
                MessageBox.Show("Error Connecting to Database");
            }
            conns.Close();

            loadDataBtn.Enabled = false;

        }



        private void forOnlyNumberTxb(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            borrowingCode = this.borrowingCodeTxb.Text;
            startGetValueOfFrom();
        }
        public static void startGetValueOfFrom()
        {
            string query = "SELECT bookid FROM borrow Where uniqueidborrow = '" + borrowingCode + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand commandata = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandata.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bookIdFromDatabase = reader.GetString("bookid");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input! Please try again");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");
            }
            startAddAvailable();
        }
        public static void startAddAvailable()
        {
            try
            {
                string connectionString = "datasource=localhost;username=root;password=;database=babythesis;";
                string query = "UPDATE inventory SET available = available + '" + 1 + "' WHERE id = '" + bookIdFromDatabase + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Done Upadating the Inventory");
                conn.Close();
                startUpdatingToReturn();
            }
            catch
            {
                MessageBox.Show("Invalid, Returning cannot proceed");
            }
        }

        public static void startUpdatingToReturn()
        {
            try
            {
                string connectionString = "datasource=localhost;username=root;password=;database=babythesis;";
                string query = "UPDATE borrow SET status = '" + "Returned" + "' WHERE uniqueidborrow = '" + borrowingCode + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("You have successfully return the book");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Invalid, Returning cannot proceed");
            }
        }

        private void refreshDataBtn_Click(object sender, EventArgs e)
        {

            borrowDataView.Rows.Clear();
            borrowDataView.Refresh();

            string userFromTempoData = temporaryDatabase.user;
            string passFromTempoData = temporaryDatabase.pass;

            string query = "SELECT studentno, email FROM registered WHERE username ='" + userFromTempoData + "' AND password = '" + passFromTempoData + "';"; // SQL query 

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand commandata = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandata.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stud = reader.GetString("studentno");
                        studEmail = reader.GetString("email");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input! Please try again" + ex);
            }
            conn.Close();

            string querys = "select * from borrow Where status = '" + "Pending" + "' and studentno = '" + stud + "';";
            MySqlConnection conns = new MySqlConnection(conString);
            MySqlCommand cmds = new MySqlCommand(querys, conns);
            MySqlDataReader myReaders;

            try
            {
                conns.Open();
                myReaders = cmds.ExecuteReader();

                while (myReaders.Read())
                {
                    string studentno = myReaders.GetString("studentno");
                    string email = myReaders.GetString("email");
                    string bookname = myReaders.GetString("bookname");
                    string status = myReaders.GetString("status");
                    string date = myReaders.GetString("date");
                    string duedate = myReaders.GetString("duedate");

                    borrowDataView.Rows.Add(studentno, email, bookname, status, date, duedate);
                }
            }
            catch
            {
                MessageBox.Show("Error Connecting to Database");
            }
            conns.Close();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentDashboard = new studentDashboard();
            studentDashboard.Closed += (s, args) => this.Close();
            studentDashboard.Show();
        }
    }
}