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
using System.Linq.Expressions;
using Org.BouncyCastle.Crypto;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml;

namespace lisen
{
    public partial class registerModule : Form
    {
        public registerModule()
        {
            InitializeComponent();
            dateTxb.MinDate = DateTime.Now; // to disable the past dates
            dateTxb.MaxDate = DateTime.Now; // to disable the past dates

        }
        // Connection String
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;";

        // Value of textbox
        public static string studentNumber;
        public static string levelOfRegister = "student";
        public static string password;
        public static string username;
        public static string firstname;
        public static string lastname;
        public static string course;
        public static string section;
        public static string email;
        public static string dateConverted;
        public static string usernameFromDatabase;
        public static bool verifyerForStudentNo;
        public static bool verifyerForUsername;
        public static bool verifiyerForEmail;
        public static bool verifyerClose;

        public static int generatedRandomNumber;
        public static string convertedGeneratedRandomNumber;


        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentnoTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(studentnoTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(usernameTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(usernameTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(passwordTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(passwordTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(firstnameTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(firstnameTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(lastnameTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(lastnameTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(courseTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(courseTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(sectionTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(sectionTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(emailTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(emailTxb, "Required Input");
                return;
            }


            studentNumber = this.studentnoTxb.Text;
            password = this.passwordTxb.Text;
            firstname = this.firstnameTxb.Text;
            username = this.usernameTxb.Text;
            lastname = this.lastnameTxb.Text;
            course = this.courseTxb.Text;   
            section = this.sectionTxb.Text;
            email = this.emailTxb.Text;
            dateConverted = dateTxb.Value.ToString("yyyy-MM-dd");

            string query = "SELECT * FROM registered"; // SQL query 
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                verifyerForStudentNo = true;
                verifyerClose = false;
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string studentNumFromDatabase = myReader.GetString("studentno"); // access and get the value of username

                        if (studentNumFromDatabase == studentNumber) // check if the username is correct 
                        {
                            verifyerForStudentNo = false;
                            break;
                        }
                    }
                }
            }
            catch  // if try became error or database connection problem
            {
                MessageBox.Show("Something Went Wrong"); // message for database connection problem
            }
            try
            {
                if (verifyerForStudentNo == true)
                {
                    checkEmailIfHasTheSame();
                }
                else
                {
                    MessageBox.Show("Invalid Student Number");
                }
            }
            catch
            {
                MessageBox.Show("asd");
            }

            if (verifyerClose == true)
            {
                this.Hide();
                var emailVerification = new emailVerification();
                emailVerification.Closed += (s, args) => this.Close();
                emailVerification.Show();
            }
            else
            {
                this.studentnoTxb.Text = "";
                this.passwordTxb.Text = "";
                this.usernameTxb.Text = "";
                this.firstnameTxb.Text = "";
                this.lastnameTxb.Text = "";
                this.courseTxb.Text = "";
                this.sectionTxb.Text = "";
                this.emailTxb.Text = "";
            }
        }

        public static void checkEmailIfHasTheSame()
        {
            string query = "SELECT * FROM registered"; // SQL query 
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                verifiyerForEmail = true;
                verifyerClose = false;
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string emailFromDatabase = myReader.GetString("email"); // access and get the value of username

                        if (emailFromDatabase == email) // check if the username is correct 
                        {
                            verifiyerForEmail = false;
                            break;
                        }
                    }
                }
            }
            catch  // if try became error or database connection problem
            {
                MessageBox.Show("Something Went Wrong"); // message for database connection problem
            }
            if (verifiyerForEmail == true)
            {
                checkerIfUsernameHasTheSame();
            }
            else
            {
                MessageBox.Show("Email already Registered");
            }
        }
        public static void checkerIfUsernameHasTheSame()
        {
            verifyerForUsername = false;

            string query = "SELECT * FROM registered"; // SQL query 
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                verifyerForUsername = true;
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string usernameFromDatabase = myReader.GetString("username"); // access and get the value of username
                        if (usernameFromDatabase == username) // check if the username is correct 
                        {
                            verifyerForUsername = false;
                            break;
                        }
                    }
                }
            }
            catch  // if try became error or database connection problem
            {
                MessageBox.Show("Something Went Wrong"); // message for database connection problem
            }

            try
            {
                if (verifyerForUsername == true)
                {
                    Random rand = new Random();
                    generatedRandomNumber = rand.Next(10000, 99999);
                    convertedGeneratedRandomNumber = Convert.ToString(generatedRandomNumber);
                    try
                    {
                        string to, from, pass, mail; // string tools for email notif
                        to = email; // forEmailNotif is the value that taken from email textbox
                        from = "janeiyo74@gmail.com"; // the use gmail for sending message using Gmail
                        mail = "You need to Verify Email to register succesfully, your student No. is " + studentNumber + " and the code is " + convertedGeneratedRandomNumber;
                        pass = "qpvyzfhkinthmfgh"; // password connection given by google 
                        MailMessage message = new MailMessage();
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = mail;
                        message.Subject = "STI Caloocan Library Registration Notification";

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);

                        smtp.Send(message); // email sender

                        MessageBox.Show("Email Done"); // indication that sending email is done

                        temporaryDatabase.codeforVeri = convertedGeneratedRandomNumber;
                        temporaryDatabase.studentNumber = studentNumber;
                        temporaryDatabase.levelOfRegister = levelOfRegister;
                        temporaryDatabase.username = username;
                        temporaryDatabase.password = password;
                        temporaryDatabase.firstname = firstname;
                        temporaryDatabase.lastname = lastname;
                        temporaryDatabase.course = course;
                        temporaryDatabase.section = section;
                        temporaryDatabase.email = email;
                        temporaryDatabase.dateConverted = dateConverted;
                        verifyerClose = true;
                        return;


                    }
                    catch
                    {
                        MessageBox.Show("Email Not Send"); // indication that sending email is error

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
            }
            catch
            {
                MessageBox.Show("asd");
            }

            



        }
        //public static void startRegistration()
        //{
        //    try
        //    {
        //        string query = "insert into registered " +
        //            "(studentno, " +
        //            "level, " +
        //            "username, " +
        //            "password, " +
        //            "firstname, " +
        //            "lastname, " +
        //            "course, " +
        //            "section, " +
        //            "email, " +
        //            "date )" +
        //        " values('" + studentNumber
        //        + "','" + levelOfRegister
        //        + "','" + username
        //        + "','" + password
        //        + "','" + firstname
        //        + "','" + lastname
        //        + "','" + course
        //        + "','" + section
        //        + "','" + email
        //        + "','" + dateConverted + "');";

        //        MySqlConnection conn = new MySqlConnection(conString);
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        MySqlDataReader myReader;

        //        conn.Open();
        //        myReader = cmd.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //        }
        //        conn.Close();
        //        MessageBox.Show("REGISTRATION SUCCESS!!!");
        //        emailNotificationRegistrationSuccess();
        //        verifyerClose = true;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("REGISTRATION FAILED");
        //    }
        //}
        //public static void emailNotificationRegistrationSuccess()
        //{
        //    try
        //    {
        //        string to, from, pass, mail; // string tools for email notif
        //        to = email; // forEmailNotif is the value that taken from email textbox
        //        from = "janeiyo74@gmail.com"; // the use gmail for sending message using Gmail
        //        mail = "You registered succesfully, your student No. is " + studentNumber;
        //        pass = "qpvyzfhkinthmfgh"; // password connection given by google 
        //        MailMessage message = new MailMessage();
        //        message.To.Add(to);
        //        message.From = new MailAddress(from);
        //        message.Body = mail;
        //        message.Subject = "STI Caloocan Library Registration Notification";

        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //        smtp.EnableSsl = true;
        //        smtp.Port = 587;
        //        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        smtp.Credentials = new NetworkCredential(from, pass);

        //        smtp.Send(message); // email sender
        //        MessageBox.Show("Email Done"); // indication that sending email is done
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Email Not Send"); // indication that sending email is error
        //    }
        //}
        private void seeOrNotBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxb.PasswordChar == '*')
            {
                passwordTxb.PasswordChar = '\0';
                Bitmap openUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\OpenEye.png");
                seeOrNotBtn.Image = openUchiha;
            }
            else if (passwordTxb.PasswordChar == '\0')
            {
                passwordTxb.PasswordChar = '*';
                Bitmap closeUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\CloseEye.png");
                seeOrNotBtn.Image = closeUchiha;
            }
        }
        private void studentNoNumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void registerModule_Load(object sender, EventArgs e)
        {
            verifyerForStudentNo = true;
            verifyerForUsername = true;
        }

        private void gotoEmailVeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var emailVerification = new emailVerification();
            emailVerification.Closed += (s, args) => this.Close();
            emailVerification.Show();
        }





        //private void backBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var Form1 = new Form1();
        //    Form1.Closed += (s, args) => this.Close();
        //    Form1.Show();
        //}


    }
}
