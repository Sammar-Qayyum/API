using Microsoft.Data.SqlClient;

namespace ProductsApi.Helpers
{
    public static class DbHelpers
    {
        private static string ConnectionString => "Server=EXPMUR\\SQLEXPRESS;Database=Products;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }


    }
}
