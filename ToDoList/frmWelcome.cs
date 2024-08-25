using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.undraw_Add_tasks_re_s5yj__3_;

            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbFacebookAccount_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100012220924655");
        }

        private void pbTelegramAccount_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/DevSanadarwish");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.Show();
            this.Hide();
        }
    }
}
