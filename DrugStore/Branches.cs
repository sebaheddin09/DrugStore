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
    public partial class Branches : Form

    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public Branches()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        private void LoadRecords()
        {
            datagw_branches.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Branches", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagw_branches.Rows.Add(i, dr["BranchName"].ToString(), dr["BranchAdress"].ToString(), dr["PhoneNumber"].ToString());
                    
            }
            dr.Close();

            con.Close();
        }

        private void btn_addBranch_Click(object sender, EventArgs e)
        {
            AddBranch ab = new AddBranch();
            ab.Show();
        }
    }
}
