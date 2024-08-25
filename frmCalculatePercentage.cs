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
    public partial class frmCalculatePercentage : Form
    {
        public frmCalculatePercentage()
        {
            InitializeComponent();
        }

        public frmCalculatePercentage(DataGridView dgvTasks)
        {
            InitializeComponent();

            _dgvTasks = dgvTasks;
        }

        DataGridView _dgvTasks = new DataGridView();

        enum enChoices
        {
            Today, ThisWeek, ThisMonth
        }
        enChoices _choice = enChoices.Today;

        enum enNamesOfColumns
        {
            colHeader, colDescription, colCategory, colStartDate, colEndDate, colStatus
        }

        enum enMarkAsCompletion
        {
            Complete, Pending
        }

        private int CalculateSumOfCompletedTasks()
        {
            int sumOfCompletedTasks = 0;

            foreach (DataGridViewRow row in _dgvTasks.Rows)
            {
                if (row.Cells[enNamesOfColumns.colStatus.ToString()].Value != null)
                {
                    if (row.Cells[enNamesOfColumns.colStatus.ToString()].Value.ToString()
                        == enMarkAsCompletion.Complete.ToString())
                        sumOfCompletedTasks++;
                }
            }

            return sumOfCompletedTasks;
        }

        private int CalculateCountOfTotalTasks(TimeSpan daysToSum)
        {
            DateTime dateNow = DateTime.Now;
            

            int countOfTotalTasks = 0;


            foreach (DataGridViewRow row in _dgvTasks.Rows)
            {
                if (row.Cells[enNamesOfColumns.colStartDate.ToString()].Value != null)
                {
                    DateTime startDate = Convert.ToDateTime(row.Cells[enNamesOfColumns.colStartDate.
                        ToString()].Value);
                    DateTime endDate = Convert.ToDateTime(row.Cells[enNamesOfColumns.colEndDate.ToString()]
                        .Value);                    
                    DateTime endDateLimit = dateNow.Add(daysToSum);


                    if(startDate <= endDateLimit && endDate >= dateNow)
                        countOfTotalTasks++;
                }

                else
                {
                    MessageBox.Show("Sorry .. You have no tasks");
                }
            }

            return countOfTotalTasks;
        }

        private double CalculateTotalPercentage(double daysToSum)
        {
            int countOfTotalTasks = CalculateCountOfTotalTasks(TimeSpan.FromDays(daysToSum));
            int sumOfCompletedTasks = CalculateSumOfCompletedTasks();

            double percentage = 100 * ((double)sumOfCompletedTasks / countOfTotalTasks);

            return percentage;
        }

        private void ConvertStringToEnum()
        {
            if (cbOptions.SelectedItem.ToString() == enChoices.Today.ToString())
                _choice = enChoices.Today;

            else if(cbOptions.SelectedItem.ToString() == enChoices.ThisWeek.ToString())
                _choice = enChoices.ThisWeek;

            else
                _choice = enChoices.ThisMonth;
        }

        private void CalculatePercentagePerChoice()
        {
            ConvertStringToEnum();

            switch(_choice)
            {
                case enChoices.Today:
                    RadialGauge.Value = (int)CalculateTotalPercentage(1);
                    lblExactPercentage.Text = RadialGauge.Value.ToString() + " %";
                    break;

                case enChoices.ThisWeek:
                    RadialGauge.Value = (int)CalculateTotalPercentage(6);
                    lblExactPercentage.Text = RadialGauge.Value.ToString() + " %";
                    break;

                case enChoices.ThisMonth:
                    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    RadialGauge.Value = (int)CalculateTotalPercentage(daysInMonth);
                    lblExactPercentage.Text = RadialGauge.Value.ToString() + " %";
                    break;
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePercentagePerChoice();
        }
    }
}
