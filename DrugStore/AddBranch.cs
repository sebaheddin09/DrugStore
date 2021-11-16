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
    public partial class AddBranch : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();

        public AddBranch()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
        }

        private void Clear()
        {
            tb_branchAdress.Clear();
            tb_branchName.Clear();
            tb_phoneNumber.Clear();
            tb_branchName.Focus();

        }

        private void btn_clearB_Click(object sender, EventArgs e)
        {
            /*tb_branchAdress.Clear();
            tb_branchName.Clear();
            tb_phoneNumber.Clear();
            tb_branchName.Focus();*/
            Clear();
        }

        private void btn_saveB_Click(object sender, EventArgs e)
        {
            try
            {

                if ( tb_branchName.Text == "" || tb_phoneNumber.Text == "" || tb_branchAdress.Text == "" )
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                con.Open();
                cmd = new SqlCommand("INSERT INTO Branches (BranchName, BranchAdress, PhoneNumber) VALUES (@BranchName, @BranchAdress, @PhoneNumber)", con);
                cmd.Parameters.AddWithValue("BranchName", tb_branchName.Text);
                cmd.Parameters.AddWithValue("@BranchAdress", tb_branchAdress.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", tb_phoneNumber.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("NEW BRANCH HAS BEEN SUCCESSFULLY SAVED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();





            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
