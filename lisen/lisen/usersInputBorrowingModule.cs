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
using static System.Windows.Forms.AxHost;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;

namespace lisen
{
    public partial class usersInputBorrowingModule : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database
        public static int checkTheBookAvailability;
        public static string getTheIdOfTheBook;
        public static string statusOfTheBook = "Pending";
        public static int generatedRandomNumber;
        public static string chosenBook;
        public static string mainDate;
        public static string returnDate;

        public static string tempoStuNum;
        public static string tempoEmailFormData;
        public usersInputBorrowingModule()
        {
            InitializeComponent();
            dateTxb.MinDate = DateTime.Now; // to disable the past dates
            dateTxb.MaxDate = DateTime.Now; // to disable the past dates
            returnDateTxb.MinDate = DateTime.Now;
            returnDateTxb.MaxDate = returnDateTxb.Value.AddDays(7);
        }

        //private void backBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var studentDashboard = new studentDashboard();
        //    studentDashboard.Closed += (s, args) => this.Close();
        //    studentDashboard.Show();
        //}

        private void submitBtn_Click(object sender, EventArgs e)
        {
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
                        tempoStuNum = reader.GetString("studentno");
                        tempoEmailFormData = reader.GetString("email");



                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input! Please try again" + ex);
            }
            conn.Close();

            Random rand = new Random();
            generatedRandomNumber = rand.Next(10000, 99999);

            chosenBook = this.bookNameTxb.Text;
            mainDate = dateTxb.Value.ToString("yyyy-MM-dd"); // converter for date value to string value
            returnDate = returnDateTxb.Value.ToString("yyyy-MM-dd"); // converter for date value to string value

            string querys = "SELECT available, id FROM inventory WHERE booktitle = '" + chosenBook + "';"; // SQL query 
            MySqlConnection conns = new MySqlConnection(conString);
            MySqlCommand cmds = new MySqlCommand(querys, conns);
            MySqlDataReader myReaders;

            try
            {
                conns.Open();
                myReaders = cmds.ExecuteReader();
                while (myReaders.Read())
                {
                    checkTheBookAvailability = myReaders.GetInt32("available"); // access and get the value of username
                    getTheIdOfTheBook = myReaders.GetString("id"); // access and get the value of username

                    break;
                }
            }
            catch(Exception ex) // if try became error or database connection problem
            {
                MessageBox.Show("error" + ex); // message for database connection problem
            }
            conns.Close();
            if (checkTheBookAvailability <= 0)
            {
                if (this.bookNameTxb.Text == "")
                {
                    MessageBox.Show("You did'nt input anything");

                }
                else
                {
                    MessageBox.Show(this.bookNameTxb.Text + " is out of stack!");
                }
            }
            else if (checkTheBookAvailability > 0)
            {
                checkTheBookAvailability -= 1;
                startInputingTheBorrowedDetails();
            }
        }

        public static void startInputingTheBorrowedDetails()
        {
            try
            {
                string query = "insert into borrow (studentno, uniqueidborrow, email, bookname, status, date, duedate, bookid)" +
                " values('" + tempoStuNum
                + "','" + generatedRandomNumber
                + "','" + tempoEmailFormData
                + "','" + chosenBook
                + "','" + statusOfTheBook
                + "','" + mainDate
                + "','" + returnDate
                + "','" + getTheIdOfTheBook + "');"; // SQL query getTheIdOfTheBook

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                }
                conn.Close();
                MessageBox.Show("BORROW INPUT SUCCESS!!!"); // Indication of success inserting to database
                startDecrementTheBooksChosen();
            }
            catch
            {
                MessageBox.Show("BORROW INPUT FAILED \n REGISTER FIRST"); // message box if not yet registered
            }
        }

        public static void startDecrementTheBooksChosen()
        {
            try
            {
                string query = "UPDATE inventory SET available = '" + checkTheBookAvailability + "' WHERE booktitle = '" + chosenBook + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Quantity of the book was succefully updated!");
                conn.Close();
                startEmailNotificationForBorrowing();
            }
            catch
            {
                MessageBox.Show("Invalid, Update cannot proceed");

            }

        }

        public static void startEmailNotificationForBorrowing()
        {
            try
            {
                string to, from, pass, mail; // string tools for email notif
                to = tempoEmailFormData; // forEmailNotif is the value that taken from email textbox
                from = "janeiyo74@gmail.com"; // the use gmail for sending message using Gmail
                mail = "Your Borrowing Code is " + generatedRandomNumber;
                pass = "qpvyzfhkinthmfgh"; // password connection given by google 
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "STI Caloocan Library Borrowing Code Notification";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                smtp.Send(message); // email sender
                MessageBox.Show("Email Done"); // indication that sending email is done
            }
            catch
            {
                MessageBox.Show("Email Not Send"); // indication that sending email is error
            }
        }

        private void usersInputBorrowingModule_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=babythesis;");
            string query = "select * from inventory";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                bookNameTxb.Items.Add(read.GetString("booktitle"));
            }
            try
            {
                String sqls = "SELECT * FROM inventory";
                MySqlConnection conns = new MySqlConnection(conString);
                MySqlCommand cmda = new MySqlCommand(sqls, conns);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmda;
                DataTable dts = new DataTable();
                adapter.Fill(dts);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = dts;
                BooksViewer.DataSource = bsource;
                adapter.Update(dts);
                BooksViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch
            {
                MessageBox.Show("Database Can't Show!!");
            }

        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM inventory WHERE booktitle LIKE'" +
                this.searchData.Text + "%' OR bookgenre LIKE'" +
                this.searchData.Text + "%' OR location LIKE'" +
                this.searchData.Text + "%' OR available LIKE'" +
                this.searchData.Text + "%' OR date LIKE'" +
                this.searchData.Text + "%'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            BooksViewer.DataSource = dt;
            conn.Close();
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM inventory";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BooksViewer.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Refresh Inventory");

            }

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
