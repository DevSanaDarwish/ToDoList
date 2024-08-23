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
using static System.Net.Mime.MediaTypeNames;

namespace ToDoList
{
    public partial class frmManageCategores : Form
    {
        int _x = 44;
        int _y = 135;
        MenuStrip _menuStrip = new MenuStrip();
        frmMainScreen _form2;

        public frmManageCategores()
        {
            InitializeComponent();
        }

        public frmManageCategores(MenuStrip menuStrip, frmMainScreen form2)
        {
            InitializeComponent();
            _menuStrip = menuStrip;
            _form2 = form2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Icon = new System.Drawing.Icon("C:\\Users\\USER\\Downloads\\oip__17__Xe1_icon.ico");
        }

        private void ConfigureTextBox(TextBox text)
        {
            text.Text = "";
            text.Multiline = true;
            text.Location = new Point(_x, _y);
            text.Size = new Size(430, 40);
            text.ForeColor = Color.White;
            text.BackColor = Color.FromArgb(128, 128, 255);
            text.BorderStyle = BorderStyle.FixedSingle;
            text.Font = new Font("Cambria", 17, FontStyle.Regular);

            this.Controls.Add(text);
        }

        private void ConfigureButtonOfDelete(TextBox text)
        {
            Guna2Button btnDeleteCategory = new Guna2Button();

            btnDeleteCategory.Text = "Delete ?";
            btnDeleteCategory.Location = new Point(500, _y);
            btnDeleteCategory.Size = new Size(97, 40);
            btnDeleteCategory.ForeColor = Color.FromArgb(192, 192, 255);
            btnDeleteCategory.FillColor = Color.FromArgb(0, 0, 64);
            btnDeleteCategory.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDeleteCategory.Click += new EventHandler(btnDeleteCategory_Click);
            btnDeleteCategory.Tag = text;

            this.Controls.Add(btnDeleteCategory);
        }

        private void AddCategory()
        {
            TextBox text = new TextBox();

            ConfigureTextBox(text);
            ConfigureButtonOfDelete(text);

            _y += 60;

            this.Refresh();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory(sender);
        }

        private void DeleteCategory(object sender)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            TextBox textBox = clickedButton.Tag as TextBox;

            this.Controls.Remove(textBox);
            this.Controls.Remove(clickedButton);

            _x = 44;
            _y = 135;

        }

        private void AddAllCategoriesToMenuStrip()
        {
            _menuStrip.BackColor = Color.FromArgb(0, 0, 64);
            _menuStrip.ForeColor = Color.White;

            foreach (Control control in this.Controls)
            {
                if(control is TextBox textBox)
                {
                    ToolStripMenuItem newItem = new ToolStripMenuItem(textBox.Text);

                    newItem.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    newItem.ForeColor = Color.White;
                    _menuStrip.Items.Add(newItem);
                }
            }
         
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            AddAllCategoriesToMenuStrip();
            
            _form2.ResetButtonsColor();
        }
    }
}
