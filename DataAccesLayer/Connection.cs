using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=SqlServerAdı;Initial Catalog=YazOkulu;Integrated Security=True");
    }
}
