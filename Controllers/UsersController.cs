using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Helpers;
using ProductsApi.Models;
using Microsoft.Data.SqlClient;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        [HttpGet]
        [Route("GetUser")]
        public List<User> GetUsers()
        {
            var users = GetUsersFromDatabase();
            return users;
        }

        private List<User> GetUsersFromDatabase()
        {
            List<User> users = new List<User>();
            var connection = DbHelpers.GetConnection();
            try
            {
                var query = "select * from Users";

                connection.Open();
                var command = new SqlCommand(query, connection);

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User();

                        user.UserId = Convert.ToInt32(reader["UserId"]);
                        user.UserName = reader["UserName"].ToString();
                        user.FirstName = reader["FirstName"].ToString(); ;
                        if (reader["UserName"] != DBNull.Value)
                        {
                            user.LastName = reader["LastName"].ToString(); ;
                        }
                        user.Password = reader["Password"].ToString(); ;
                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return users;
        }

    }


}
