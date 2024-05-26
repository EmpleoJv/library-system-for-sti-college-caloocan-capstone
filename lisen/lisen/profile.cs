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
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Org.BouncyCastle.Crypto;

namespace lisen
{
    public partial class profile : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database
        public static string stuNo;
        public static string level;
        public static string userName;
        public static string passWord;
        public static string firstName;
        public static string lastName;
        public static string course;
        public static string section;
        public static string email;

        public static string studentForReturn;


        public static bool forVerification = true;

        public profile()
        {
            InitializeComponent();
        }



        private void profile_Load(object sender, EventArgs e)
        {
            string userFromTempoData = temporaryDatabase.user;
            string passFromTempoData = temporaryDatabase.pass;

            string query = "SELECT * FROM registered WHERE username ='" + userFromTempoData + "' AND password = '" + passFromTempoData + "';"; // SQL query 

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
                        stuNo = reader.GetString("studentno");
                        string level = reader.GetString("level");
                        string userName = reader.GetString("username");
                        string passWord = reader.GetString("password");
                        string firstName = reader.GetString("firstname");
                        string lastName = reader.GetString("lastname");
                        string course = reader.GetString("course");
                        string section = reader.GetString("section");
                        email = reader.GetString("email");

                        studNoViewer.Text = stuNo;
                        statusViewer.Text = level;
                        userViewer.Text = userName;
                        passViewer.Text = passWord;
                        firstnameViewer.Text = firstName;
                        lastnameViewer.Text = lastName;
                        courseViewer.Text = course;
                        sectionViewer.Text = section;
                        emailViewer.Text = email;

                        temporaryDatabase.tempoEmail = email;
                        temporaryDatabase.studentNum = stuNo; 
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input! Please try again" + ex);
            }


        }


        private void seeOrNotBtn_Click(object sender, EventArgs e)
        {
            if (passViewer.PasswordChar == '*')
            {
                passViewer.PasswordChar = '\0';
                Bitmap openUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\OpenEye.png");
                seeOrNotBtn.Image = openUchiha;
            }
            else if (passViewer.PasswordChar == '\0')
            {
                passViewer.PasswordChar = '*';
                Bitmap openUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\CloseEye.png");
                seeOrNotBtn.Image = openUchiha;
            }
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passViewer.Text.Trim())) // required input for Student No.
            {
                errorEmpty.SetError(passViewer, "Required Input");
                return;
            }

            try
            {
                string query = "UPDATE registered SET password = '" + this.passViewer.Text + "' WHERE studentno = '" + this.studNoViewer.Text + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Succefully Update!");
                conn.Close();
                temporaryDatabase.pass = this.passViewer.Text;


            }
            catch
            {
                MessageBox.Show("Invalid Input");

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