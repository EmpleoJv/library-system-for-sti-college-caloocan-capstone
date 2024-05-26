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
using Microsoft.Win32;

namespace lisen
{
    public partial class userModule : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database

        public userModule()
        {
            InitializeComponent();
        }

        private void userModule_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM borrow";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridBorrow.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Show Database");
            }
        }

        private void clickDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridBorrow.Rows[e.RowIndex];
                studentNo.Text = row.Cells[1].Value.ToString();
                studentEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void emailTxb_Click(object sender, EventArgs e)
        {

            try
            {
                string to, from, pass, mail; // string tools for email notif
                to = this.studentEmail.Text; // forEmailNotif is the value that taken from email textbox
                from = "janeiyo74@gmail.com"; // the use gmail for sending message using Gmail
                mail = "Message from the Library Admin: " + this.messageTxb.Text;
                pass = "qpvyzfhkinthmfgh"; // password connection given by google 
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "STI Caloocan Library Return Books Notification";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                smtp.Send(message); // email sender
                MessageBox.Show("Email Done"); // indication that sending email is done
                this.messageTxb.Text = "";
            }
            catch
            {
                MessageBox.Show("Email Not Send"); // indication that sending email is error
            }

        }

        //private void backBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var adminDashboard = new adminDashboard();
        //    adminDashboard.Closed += (s, args) => this.Close();
        //    adminDashboard.Show();
        //}

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM borrow WHERE studentno LIKE'" +
                this.searchData.Text + "%' OR uniqueidborrow LIKE'" +
                this.searchData.Text + "%' OR email LIKE'" +
                this.searchData.Text + "%' OR bookname LIKE'" +
                this.searchData.Text + "%' OR status LIKE'" +
                this.searchData.Text + "%' OR date LIKE'" +
                this.searchData.Text + "%' OR duedate LIKE'" +
                this.searchData.Text + "%'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dataGridBorrow.DataSource = dt;
            conn.Close();
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
