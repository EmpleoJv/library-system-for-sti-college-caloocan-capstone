using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class addBookModule : Form
    {
        public addBookModule()
        {
            InitializeComponent();
            dateTxb.MinDate= DateTime.Now;
        }
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;";

        public static string bookName;
        public static string bookGenre;
        public static string bookLocation;
        public static string bookQuantity;
        public static int bookQuantityConverter;
        public static string bookDateBeenStock;

        public static bool duplicatedBookChecker = true;


        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookTxb.Text.Trim())) // required input for Student No.
            {
                errorProvideEmpty.SetError(bookTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(genreTxb.Text.Trim())) // required input for Student No.
            {
                errorProvideEmpty.SetError(genreTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(locationTxb.Text.Trim())) // required input for Student No.
            {
                errorProvideEmpty.SetError(locationTxb, "Required Input");
                return;
            }
            else if (string.IsNullOrEmpty(quantityTxb.Text.Trim())) // required input for Student No.
            {
                errorProvideEmpty.SetError(quantityTxb, "Required Input");
                return;
            }
            
            bookName = this.bookTxb.Text;
            bookGenre = this.genreTxb.Text;
            bookLocation = this.locationTxb.Text;
            bookQuantity = this.quantityTxb.Text;
            bookQuantityConverter = Int32.Parse(bookQuantity);
            bookDateBeenStock = dateTxb.Value.ToString("yyyy-MM-dd");

            string query = "SELECT * FROM inventory"; // SQL query 
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string bookFromDatabase = myReader.GetString("booktitle"); // access and get the value of username

                        if (bookFromDatabase == bookName) // check if the username is correct 
                        {
                            duplicatedBookChecker = false;
                            break;
                        }
                    }
                }
            }
            catch  // if try became error or database connection problem
            {
                MessageBox.Show("Something Went Wrong"); // message for database connection problem
            }
            if (duplicatedBookChecker == true)
            {
                insertAnotherBook();
            }
            else
            {
                MessageBox.Show("Invalid Book name, Already Exist!!");
                this.bookTxb.Text = "";
                this.genreTxb.Text = "";
                this.locationTxb.Text = "";
                this.quantityTxb.Text = "";
            }
            this.bookTxb.Text = "";
            this.genreTxb.Text = "";
            this.locationTxb.Text = "";
            this.quantityTxb.Text = "";
        }
        public static void insertAnotherBook()
        {
            try
            {
                string query = "insert into inventory " +
                    "(booktitle, " +
                    "bookgenre, " +
                    "location, " +
                    "available, " +
                    "date)" +
                " values('" + bookName
                + "','" + bookGenre
                + "','" + bookLocation
                + "','" + bookQuantityConverter
                + "','" + bookDateBeenStock + "');";

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader myReader;

                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                }
                conn.Close();
                MessageBox.Show("Book Added SUCCESFULLY!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Book Added FAILED!!!" + ex);
            }
        }


        private void quantityNumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
