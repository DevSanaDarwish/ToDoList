using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmSetTimer : Form
    {
        public frmSetTimer()
        {
            InitializeComponent();
        }



        StringBuilder _formattedChosenTime = new StringBuilder();
        TimeSpan _chosenTime = new TimeSpan();
        string _defaultText = "Add your task";
        
        enum enPause { Pause, Resume};

        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
                btnAdd.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTask.SelectionStart = txtTask.Text.Length;
            txtTask.SelectionLength = 0;
        }

        private void SetChosenTime()
        {
            int hours = Convert.ToInt32(nudHours.Value);
            int minutes = Convert.ToInt32(nudMinutes.Value);

            _chosenTime = new TimeSpan(hours, minutes, 0);
        }

        private void StartTimer()
        {
            TimeSpan oneSecond = new TimeSpan(0, 0, 1);

            _chosenTime -= oneSecond;

            _formattedChosenTime.AppendFormat("{0:00}:{1:00}:{2:00}",
                _chosenTime.TotalHours, _chosenTime.Minutes, _chosenTime.Seconds);

            lblTimer.Text = _formattedChosenTime.ToString();

            _formattedChosenTime.Clear();

            if(_chosenTime <= TimeSpan.Zero)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipText = "Time's up";

                notifyIcon1.ShowBalloonTip(1000);

                lblTimer.Text = TimeSpan.Zero.ToString();

                timer1.Stop();
            }
        }

        private void Reset()
        {
            txtTask.Text = _defaultText;
            nudHours.Value = 0;
            nudMinutes.Value = 0;
        }

        private void AddTimer()
        {
            SetChosenTime();

            lblTimer.Text = _chosenTime.ToString(@"hh\:mm\:ss");

            timer1.Start();

            lblTitle.Text = txtTask.Text;

            btnPause.Visible = true;
            btnDelete.Visible = true;

            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudHours.Value == 0 && nudMinutes.Value == 0)
                MessageBox.Show("You must choose a valid value");

            else if (!string.IsNullOrEmpty(txtTask.Text))
                AddTimer();
        }

        private void txtTask_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == "Add your task")
                txtTask.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Text == enPause.Pause.ToString())
            {
                btnPause.Text = enPause.Resume.ToString();
                btnPause.BackColor = Color.FromArgb(192, 192, 0);
                timer1.Stop();
            }

            else
            {
                btnPause.Text = enPause.Pause.ToString();
                btnPause.BackColor = Color.FromArgb(0, 192, 0);
                timer1.Start();
            }
        }

        private void txtTask_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTask.Text))
            {
                e.Cancel = true;
                txtTask.Focus();
                errorProvider1.SetError(txtTask, "You should write a task!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTask, "");
            }
        }

        private void DeleteTimer()
        {
            timer1.Stop();

            lblTitle.Text = "";
            lblTimer.Text = "";

            btnPause.Visible = false;
            btnDelete.Visible = false;

            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTimer();
        }
    }
}
