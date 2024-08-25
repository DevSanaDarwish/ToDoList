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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ToDoList
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }
        
       

        string _defaultStartDate = "";
        string _defaultEndDate = "";
        string _defaultCategory = "";
        string _defaultStatus = "";
        int _count = 1;
        bool _isChecked = false;
        ToolStripMenuItem _clickedItem;

        enum enMarkAsCompletion
        {
            Complete, Pending
        }
        enMarkAsCompletion _markAsCompletion = enMarkAsCompletion.Pending;

        enum enNamesOfColumns
        {
            colHeader, colDescription, colCategory, colStartDate, colEndDate, colStatus
        }

        private void SetDefaultStartDate()
        {
            _defaultStartDate = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void SetDefaultEndDate()
        {
            DateTime timeNow = DateTime.Now;
            TimeSpan oneDay = TimeSpan.FromDays(1);

            _defaultEndDate = (timeNow + oneDay).ToString("MM/dd/yyyy");
        }

        private void SetDefaultValueForCategory(string categoryName)
        {
            _defaultCategory = categoryName;
        }

        private void SetDefaultValueForStatus()
        {
            _defaultStatus = enMarkAsCompletion.Pending.ToString();
        }

        private string[] SetDefaultValuesInRow(string categoryName)
        {
            SetDefaultStartDate();
            SetDefaultEndDate();
            SetDefaultValueForCategory(categoryName);
            SetDefaultValueForStatus();
           

            string[] defaultRow = new string[]
            {
                _isChecked.ToString(), "",
                _defaultCategory, 
                _defaultStartDate,
                _defaultEndDate, 
                _defaultStatus 
            };

            _count++;
            return defaultRow;
        }

        private void SetDefaultValueInDateTimePicker()
        {
            dtp.Value = DateTime.Now;
        }

        private void SetClickingOnPersonalToolStripMenuItem()
        {
            personalToolStripMenuItem.PerformClick();
        }

        private void SetClickingOnBtnAll()
        {
           btnAll.PerformClick();
        }

        private void ConfigureDataGridView()
        {
            dgvShowTasks.AllowUserToAddRows = false;
            dgvShowTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowTasks.MultiSelect = false;
            dgvShowTasks.Font = new Font("Arial", 20);
            dgvShowTasks.RowTemplate.Height = 40;
            dgvShowTasks.ColumnHeadersHeight = 100;
            dgvShowTasks.DefaultCellStyle.Font = new Font("Arial", 14);
            dgvShowTasks.Columns[0].Width = 80;
            dgvShowTasks.Columns[1].Width = 400;
            dgvShowTasks.Columns[2].Width = 190;
            dgvShowTasks.Columns[3].Width = 190;
            dgvShowTasks.Columns[4].Width = 190;
            dgvShowTasks.Columns[5].Width = 190;

            dgvShowTasks.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultValueInDateTimePicker();
            SetClickingOnPersonalToolStripMenuItem();
            ConfigureDataGridView();
        }

        private void AddTask(string categoryName)
        {
            string[] row = SetDefaultValuesInRow(categoryName);

            dgvShowTasks.Rows.Add(row);

            int newRowIndex = dgvShowTasks.Rows.Count - 1;

            dgvShowTasks.CurrentCell = dgvShowTasks.Rows[newRowIndex].Cells
                [enNamesOfColumns.colDescription.ToString()];

            dgvShowTasks.BeginEdit(true);

            dgvShowTasks.ClearSelection();
        }

        private void ResetOneButtonColor(Guna2Button button)
        {
            button.BackColor = Color.Transparent;
        }

        private void ResetOneToolStripMenuItemColor(ToolStripMenuItem item)
        {
            item.BackColor = Color.Transparent;
        }

        private void ResetToolStripMenuItemsColor(ToolStripItemCollection items)
        {
            foreach(ToolStripMenuItem item in items)
            {
                ResetOneToolStripMenuItemColor(item);
            }
        }

        private void ColoringOneToolStripMenuItem(ToolStripMenuItem item)
        {
            item.BackColor = Color.Orchid;
        }

        public void ResetButtonsColor()
        {
            ResetOneButtonColor(btnAll);
            ResetOneButtonColor(btnManage);
            ResetOneButtonColor(btnPending);
            ResetOneButtonColor(btnComplete);
        }

        private void ColoringButton(Guna2Button button)
        {
            button.BackColor = Color.Orchid;
        }

        private void ShowAllTasks()
        {
            foreach(DataGridViewRow row in dgvShowTasks.Rows)
            {
                row.Visible = true;
            }
        }

        private void FilterTasksByStatus(string status)
        {
            foreach (DataGridViewRow row in dgvShowTasks.Rows)
            {
                if (row.Cells[enNamesOfColumns.colStatus.ToString()].Value != null)
                {
                    string rowValue = row.Cells[enNamesOfColumns.colStatus.ToString()].
                        Value.ToString();

                    if (rowValue == status)
                        row.Visible = true;


                    else
                        row.Visible = false;

                }

            }
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            ResetToolStripMenuItemsColor(menuStrip1.Items);
            ResetButtonsColor();
            ColoringButton(btnAll);
            ShowAllTasks();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            ResetToolStripMenuItemsColor(menuStrip1.Items);
            ResetButtonsColor();
            ColoringButton(btnPending);

            _markAsCompletion = enMarkAsCompletion.Pending;
            FilterTasksByStatus(_markAsCompletion.ToString());
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            ResetToolStripMenuItemsColor(menuStrip1.Items);
            ResetButtonsColor();
            ColoringButton(btnComplete);

            _markAsCompletion = enMarkAsCompletion.Complete;
            FilterTasksByStatus(_markAsCompletion.ToString());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ResetToolStripMenuItemsColor(menuStrip1.Items);
            ResetButtonsColor();
            ColoringButton(btnManage);

            frmManageCategores form2 = new frmManageCategores(menuStrip1, this);  
            form2.Show();
        }

        private void ColoringRows(DataGridViewRowPrePaintEventArgs e)
        {
            dgvShowTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);

            dgvShowTasks.DefaultCellStyle.SelectionBackColor = Color.Orchid;
            dgvShowTasks.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void dgvShowTasks_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ColoringRows(e);
        }
        
        private void DeleteTask()
        {
            if (dgvShowTasks.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this task?",
                    "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    dgvShowTasks.Rows.RemoveAt(dgvShowTasks.SelectedRows[0].Index);

            }

            else
                MessageBox.Show("Please select a row to delete");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTask(_clickedItem.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }

        private void SearchByStartDate()
        {
            DateTime selectedDate = dtp.Value.Date;

            dgvShowTasks.ClearSelection();

            foreach (DataGridViewRow row in dgvShowTasks.Rows)
            {
                if (row.Cells[enNamesOfColumns.colStartDate.ToString()].Value != null)
                {
                    DateTime rowDate = Convert.ToDateTime(row.Cells
                        [enNamesOfColumns.colStartDate.ToString()].Value).Date;

                    if (rowDate == selectedDate)
                    {
                        row.Visible = true;
                    }

                    else
                    {
                        row.Visible = false;
                    }

                }
            }
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            SearchByStartDate();
        }

        private void dgvShowTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvShowTasks.Columns
                [enNamesOfColumns.colHeader.ToString()].Index && e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(dgvShowTasks.Rows[e.RowIndex].Cells
                    [e.ColumnIndex].Value);


                dgvShowTasks.Rows[e.RowIndex].Cells
                    [enNamesOfColumns.colStatus.ToString()].Value = isChecked
                    ? enMarkAsCompletion.Complete.ToString()
                    : enMarkAsCompletion.Pending.ToString();
            }
        }

        private void dgvShowTasks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvShowTasks.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvShowTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ResetButtonsColor();

            _clickedItem = e.ClickedItem as ToolStripMenuItem;

            if (_clickedItem != null)
            {
                string filterValue = _clickedItem.Text;

                foreach (DataGridViewRow row in dgvShowTasks.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    
                    string categoryValue = row.Cells
                            [enNamesOfColumns.colCategory.ToString()].Value.ToString();

                    row.Visible = categoryValue.Equals(filterValue, StringComparison.OrdinalIgnoreCase);
                    

                }
            }



            if (_clickedItem != null)
            {
                ResetToolStripMenuItemsColor(menuStrip1.Items);
                ColoringOneToolStripMenuItem(_clickedItem);
            }

        }

        private void SearchItem(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvShowTasks.Rows)
                {
                    row.Visible = false;
                }

                foreach (DataGridViewRow row in dgvShowTasks.Rows)
                {
                    if (row.Cells[enNamesOfColumns.colDescription.ToString()].Value != null &&
                        row.Cells[enNamesOfColumns.colDescription.ToString()].Value.ToString()
                        .IndexOf(sentenceToSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {

                foreach (DataGridViewRow row in dgvShowTasks.Rows)
                {
                    row.Visible = true;
                }
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Item...")
                txtSearch.Text = "";
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            SearchItem(txtSearch.Text);
        }

        private void btnCalculatePercentage_Click(object sender, EventArgs e)
        {
            frmCalculatePercentage calculatePercentage = new frmCalculatePercentage(dgvShowTasks);
            calculatePercentage.Show();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            frmSetTimer form3 = new frmSetTimer();
            form3.Show();
        }

        private void frmMainScreen_Click(object sender, EventArgs e)
        {
            dgvShowTasks.ClearSelection();
        }

    }
}
