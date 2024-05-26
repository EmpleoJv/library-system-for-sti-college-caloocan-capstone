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
using MySql.Data.MySqlClient;

namespace lisen
{
    public partial class emailVerification : Form
    {

        public emailVerification()
        {
            InitializeComponent();

        }
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;";

        private void numOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubmitCodeBtn_Click(object sender, EventArgs e)
        {
            if (temporaryDatabase.codeforVeri == this.codeTxb.Text)
            {
                try
                {
                    string query = "insert into registered " +
                        "(studentno, " +
                        "level, " +
                        "username, " +
                        "password, " +
                        "firstname, " +
                        "lastname, " +
                        "course, " +
                        "section, " +
                        "email, " +
                        "date )" +
                    " values('" + temporaryDatabase.studentNumber
                    + "','" + temporaryDatabase.levelOfRegister
                    + "','" + temporaryDatabase.username
                    + "','" + temporaryDatabase.password
                    + "','" + temporaryDatabase.firstname
                    + "','" + temporaryDatabase.lastname
                    + "','" + temporaryDatabase.course
                    + "','" + temporaryDatabase.section
                    + "','" + temporaryDatabase.email
                    + "','" + temporaryDatabase.dateConverted + "');";

                    MySqlConnection conn = new MySqlConnection(conString);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader myReader;

                    conn.Open();
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                    }
                    conn.Close();
                    MessageBox.Show("REGISTRATION SUCCESS!!!");



                    this.Hide();
                    var Form1 = new Form1();
                    Form1.Closed += (s, args) => this.Close();
                    Form1.Show();



                }
                catch
                {
                    MessageBox.Show("REGISTRATION FAILED");
                    this.codeTxb.Text = "";

                }
            }
            else
            {
                MessageBox.Show("You input a wrong Code");
                this.codeTxb.Text = "";
            }

            
        }

        private void emailVerification_Load(object sender, EventArgs e)
        {
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerModule = new registerModule();
            registerModule.Closed += (s, args) => this.Close();
            registerModule.Show();
        }
    }
}
