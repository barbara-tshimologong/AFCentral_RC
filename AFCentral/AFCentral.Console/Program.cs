using DataAccess;

namespace AFCentral.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AFCentral; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            DataAccess.SqlServer ss = new DataAccess.SqlServer(connectionString);

            var reply = ss.DbConnect();

            System.Console.WriteLine(reply);


        }
    }
}
