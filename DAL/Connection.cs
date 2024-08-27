using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection
            (@"Data Source=(localdb)\MSSQLLocalDB; initial Catalog=YazOkulu; integrated Security=true");

    }
}
