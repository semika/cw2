using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common
{
    public class DBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9KUI6OD;Initial Catalog=IIT-EAD;Integrated Security=True");
    }
}
