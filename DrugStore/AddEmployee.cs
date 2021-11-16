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
    public partial class AddEmployee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
       
        public AddEmployee()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
        }

        private void Clear()
        {
            tb_adress.Clear();
            tb_branchadress.Clear();
            tb_employeeID.Clear();
            tb_name.Clear();
            tb_phonenumber.Clear();
            tb_status.Clear();
            tb_surname.Clear();
            tb_birthdate.Clear();
            tb_employeeID.Focus();
        }


        private void btn_clearE_Click(object sender, EventArgs e)
        {
            /*tb_employeeID.Clear();
            tb_name.Clear();
            tb_status.Clear();
            tb_surname.Clear();
            tb_branchadress.Clear();
            tb_adress.Clear();
            tb_phonenumber.Clear();
            tb_birthdate.Clear();
            tb_employeeID.Focus();*/
            Clear();
          
        }

        private void btn_saveE_Click(object sender, EventArgs e)
        {

            try
            {
                
                if(/*tb_employeeID.Text = "" */ tb_status.Text == "" && tb_name.Text == "" && tb_surname.Text == "" && tb_phonenumber.Text == "" && tb_birthdate.Text == "" || tb_adress.Text == ""  &&  tb_branchadress.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                con.Open();
                cmd = new SqlCommand("INSERT INTO Employees (EmployeeID, EmployeeName, EmployeeSurname, EmployeeStatus, BirthDate, PhoneNumber, Adress, BranchAdress) VALUES (@EmployeeID, @EmployeeName, @EmployeeSurname, @EmployeeStatus, @BirthDate, @PhoneNumber, @Adress, @BranchAdress) ", con);
                cmd.Parameters.AddWithValue("@EmployeeID", tb_employeeID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", tb_name.Text);
                cmd.Parameters.AddWithValue("@EmployeeSurname", tb_surname.Text);
                cmd.Parameters.AddWithValue("@EmployeeStatus", tb_status.Text);
                cmd.Parameters.AddWithValue("@BirthDate", tb_birthdate.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", tb_phonenumber.Text);
                cmd.Parameters.AddWithValue("@Adress", tb_adress.Text);
                cmd.Parameters.AddWithValue("@BranchAdress", tb_branchadress.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("NEW EMPLOYEE HAS BEEN SUCCESSFULLY SAVED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                
               




                
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
           
        }
    }
}
