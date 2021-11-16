using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DrugStore
{
    public partial class Employees : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public Employees()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            datagw_employees.Rows.Clear();
            int  i  = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Employees", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagw_employees.Rows.Add(i, dr["EmployeeID"].ToString(), dr["EmployeeName"].ToString(), dr["EmployeeSurname"].ToString(), dr["EmployeeStatus"].ToString(), dr["BirthDate"].ToString(), dr["PhoneNumber"].ToString(), dr["Adress"].ToString(), dr["BranchAdress"].ToString());

            }
            dr.Close();

            con.Close();


        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
        }
    }
}
