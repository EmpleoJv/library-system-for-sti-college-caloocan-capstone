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
    public partial class studentDashboard : Form
    {
        public studentDashboard()
        {
            InitializeComponent();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profile = new profile();
            profile.Closed += (s, args) => this.Close();
            profile.Show();
        }

        private void usersInputModuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var usersInputBorrowingModule = new usersInputBorrowingModule();
            usersInputBorrowingModule.Closed += (s, args) => this.Close();
            usersInputBorrowingModule.Show();
        }

        private void borrowedBooksModuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var returnBooksModule = new returnBooksModule();
            returnBooksModule.Closed += (s, args) => this.Close();
            returnBooksModule.Show();
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