using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lisen
{
    public partial class booksInventoryModule : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database


        public booksInventoryModule()
        {
            InitializeComponent();
        }

        public static string namebook;
        public static string genrebook;
        public static string locationbook;
        public static string availablebook;
        public static string idbook;

        public static string statusofthebook;

        private void booksInventoryModule_Load(object sender, EventArgs e)
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
                booksInventoryGrid.DataSource = dt;
            }
            catch 
            {
                MessageBox.Show("Cannot Show Database");
            }

        }




        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(bookTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(genreTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(genreTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(locationTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(locationTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(availableTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(availableTxb, "Required Input");
                return;
            }

            namebook = this.bookTxb.Text;
            genrebook = this.genreTxb.Text;
            locationbook = this.locationTxb.Text;
            availablebook = this.availableTxb.Text;
            idbook = this.idTxb.Text;

            string query = "SELECT status FROM borrow WHERE bookid = '" + idbook + "';";
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
                        statusofthebook = reader.GetString("status");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");
            }
            try
            {
                if (statusofthebook == "Pending")
                {
                    MessageBox.Show(" Someone Borrowed this Boook, You can't proceed for now");
                    statusofthebook = null;
                }
                else
                {
                    MessageBox.Show(" No one borrowed this book good job");

                    startUpdatingTheBooks();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }

        }
        public static void startUpdatingTheBooks()
        {
            try
            {
                string query = "UPDATE inventory SET booktitle = '" + namebook + "', bookgenre = '" + genrebook + "', location = '" + locationbook + "', available = '" + availablebook + "' WHERE id = '" + idbook + "';"; // SQL query

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Succefully Update!");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void clickPutDataToTxb(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.booksInventoryGrid.Rows[e.RowIndex];
                idTxb.Text = row.Cells[0].Value.ToString();
                bookTxb.Text = row.Cells[1].Value.ToString();
                genreTxb.Text = row.Cells[2].Value.ToString();
                locationTxb.Text = row.Cells[3].Value.ToString();
                availableTxb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
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
                booksInventoryGrid.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cannot Refresh Database");

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
            booksInventoryGrid.DataSource = dt;
            conn.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTxb.Text = "";
            bookTxb.Text = "";
            genreTxb.Text = "";
            locationTxb.Text = "";
            availableTxb.Text = "";
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(bookTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(genreTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(genreTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(locationTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(locationTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(availableTxb.Text.Trim())) // required input for Student No.
            {
                errorIfEmpty.SetError(availableTxb, "Required Input");
                return;
            }

            namebook = this.bookTxb.Text;
            genrebook = this.genreTxb.Text;
            locationbook = this.locationTxb.Text;
            availablebook = this.availableTxb.Text;
            idbook = this.idTxb.Text;



            string query = "SELECT status FROM borrow WHERE bookid = '" + this.idTxb.Text + "';";
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
                        statusofthebook = reader.GetString("status");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");
            }
            try
            {
                if (statusofthebook == "Pending")
                {
                    MessageBox.Show(" Someone Borrowed this Boook, You can't proceed for now");
                    statusofthebook = null;

                }
                else
                {
                    MessageBox.Show(" No one borrowed this book good job");
                    startDeletingAfterCheckingIfSomeoneBorrowedTheBook();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
        public static void startDeletingAfterCheckingIfSomeoneBorrowedTheBook()
        {
            string query = "DELETE FROM inventory WHERE id = '" + idbook + "';";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Delete Succefully!");
            conn.Close();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBookModule addBok = new addBookModule();
            addBok.Show();
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
