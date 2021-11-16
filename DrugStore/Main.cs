using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Employees());
            lbl_header.Text = "EMPLOYEES";
          
        }

        private Form activeForm = null;
        private void openEmployeeForm(Form employeeForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = employeeForm;
            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(employeeForm);
            panel_main.Tag= employeeForm;
            employeeForm.BringToFront();
            employeeForm.Show();
            
        }

        private void btn_branches_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Branches());
            lbl_header.Text = "BRANCHES";
        }

        private void btn_drugs_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Drugs());
            lbl_header.Text = "DRUGS";
         
                    
        }

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            panel_main.Visible = true;
        }
    }
}
