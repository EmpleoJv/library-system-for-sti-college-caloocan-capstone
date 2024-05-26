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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void borrowersModuleBnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userModule = new userModule();
            userModule.Closed += (s, args) => this.Close();
            userModule.Show();
        }



        private void booksModuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var booksInventoryModule = new booksInventoryModule();
            booksInventoryModule.Closed += (s, args) => this.Close();
            booksInventoryModule.Show();
        }

        private void registeredModuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registeredModule = new registeredModule();
            registeredModule.Closed += (s, args) => this.Close();
            registeredModule.Show();
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
