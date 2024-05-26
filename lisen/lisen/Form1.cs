using MySql.Data.MySqlClient;

namespace lisen
{
    public partial class Form1 : Form
    {
        public static string conString = "datasource=localhost;username=root;password=;database=babythesis;"; // to connect and access the xampp database


        public Form1()
        {
            InitializeComponent();
        }

        private void loginTxb_Click(object sender, EventArgs e)
        {

            temporaryDatabase.user = this.usernameTxb.Text;
            temporaryDatabase.pass = this.passTxb.Text;

            string query = "SELECT * FROM registered WHERE username ='" + this.usernameTxb.Text + "'AND password ='" + this.passTxb.Text + "'";
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
                        string level = reader.GetString("level");
                        if (level == "admin")
                        {
                            this.Hide();
                            var adminDashboard = new adminDashboard();
                            adminDashboard.Closed += (s, args) => this.Close();
                            adminDashboard.Show();
                            break;
                        }
                        else if (level == "student")
                        {
                            this.Hide();
                            var studentDashboard = new studentDashboard();
                            studentDashboard.Closed += (s, args) => this.Close();
                            studentDashboard.Show();
                            break;
                        }
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
        }


        private void seeOrNotBtn_Click(object sender, EventArgs e)
        {
            if (passTxb.PasswordChar == '*')
            {
                passTxb.PasswordChar = '\0';
                Bitmap openUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\OpenEye.png");
                seeOrNotBtn.Image = openUchiha;
            }
            else if (passTxb.PasswordChar == '\0')
            {
                passTxb.PasswordChar = '*';
                Bitmap openUchiha = new Bitmap(@"C:\Users\janei\OneDrive\Desktop\Lisen Thing\images\CloseEye.png");
                seeOrNotBtn.Image = openUchiha;
            }
        }

        private void registerTxb_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerModule = new registerModule();
            registerModule.Closed += (s, args) => this.Close();
            registerModule.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void forgotLble_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var forgotPassowordModule = new forgotPassowordModule();
            forgotPassowordModule.Closed += (s, args) => this.Close();
            forgotPassowordModule.Show();
        }
    }
}