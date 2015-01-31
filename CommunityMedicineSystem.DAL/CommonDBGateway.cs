using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CommunityMedicineSystem.DAL
{
    public class CommonDBGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["CommunityMedicine"].ConnectionString;
        public SqlConnection ASqlConnection;
        public SqlCommand ASqlCommand;
        public SqlDataReader ASqlDataReader;

        public CommonDBGateway()
        {
            ASqlConnection = new SqlConnection(connectionString);
        }
    }
}
