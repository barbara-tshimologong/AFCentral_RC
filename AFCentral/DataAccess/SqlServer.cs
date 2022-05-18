using System.Data.SqlClient;

namespace DataAccess
{
    public class SqlServer
    {

        private string _cnString;
        public SqlServer(string cn)
        {
            _cnString = cn;
        }
        public string DbConnect()
        {
            return "you have connected.!!!";

        }

    }
}
