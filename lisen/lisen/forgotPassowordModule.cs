using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lisen
{
    public partial class forgotPassowordModule : Form
    {
        public forgotPassowordModule()
        {
            InitializeComponent();
        }
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database
        public static string emailFormData;
        public static string studentNoFormData;
        public static string passwordFormData;
        public static string usernameFormData;

        public static int generatedRandomNumber;
        public static string generatedRandomNumberCoverted;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(emailTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(studentNo.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(studentNo, "Required Input");
                return;
            }
            //string userFromTempoData = temporaryDatabase.user;
            //string passFromTempoData = temporaryDatabase.pass;

            string query = "SELECT * FROM registered WHERE email ='" + this.emailTxb.Text + "'AND studentno = '" + this.studentNo.Text + "';"; // SQL query 

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
                        studentNoFormData = reader.GetString("studentno");
                        emailFormData = reader.GetString("email");
                        passwordFormData = reader.GetString("password");
                        usernameFormData = reader.GetString("username");
                        break;
                    }
                }
                startGeneratingRandomNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input! \n Make sure Student No. is connected to the Email" + ex);
                this.emailTxb.Text = String.Empty;
                this.studentNo.Text = String.Empty;
            }
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        public static void startGeneratingRandomNumber()
        {
            Random rand = new Random();
            generatedRandomNumber = rand.Next(50000,99999);
            generatedRandomNumberCoverted = Convert.ToString(generatedRandomNumber);

            startUpdatingThePassword();
        }
        public static void startUpdatingThePassword()
        {
            try
            {
                string query = "UPDATE registered SET password = '" + generatedRandomNumberCoverted + "' WHERE studentno = '" + studentNoFormData + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Succefully Update!");
                conn.Close();
                startEmailForForgotPassword();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
        public static void startEmailForForgotPassword()
        {
            try
            {
                string to, from, pass, mail; // string tools for email notif
                to = emailFormData; // forEmailNotif is the value that taken from email textbox
                from = "janeiyo74@gmail.com"; // the use gmail for sending message using Gmail
                mail = "Your new Password is " + generatedRandomNumberCoverted + ", and your username is " + usernameFormData;
                pass = "qpvyzfhkinthmfgh"; // password connection given by google 
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "STI Caloocan Library Forgot Password Notification";

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
            return;
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }
    }
}
