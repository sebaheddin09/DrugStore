using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrugStore
{
    class ConnectionDB
    {
        public string GetConnection()
        {
            string con = @"Data Source=DESKTOP-8VJ7USG;Initial Catalog=DrugStore;Integrated Security=True";
            return con;

        }
    }
}
