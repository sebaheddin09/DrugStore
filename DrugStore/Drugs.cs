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

    


    public partial class Drugs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public Drugs()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            datagw_drugs.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Drugs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagw_drugs.Rows.Add(i, dr["DrugID"].ToString(), dr["DrugName"].ToString(), dr["Destination"].ToString(), dr["Value"].ToString());

            }
            dr.Close();

            con.Close();
        }

        private void btn_addDrug_Click(object sender, EventArgs e)
        {
            AddDrug ad = new AddDrug();
            ad.Show();
        }
    }
    /*private void btn_addDrug_Click(object sender, EventArgs e)
        {
            AddDrug ad = new AddDrug();
            ad.Show();
        }*/
    }

