using System.Data.SqlClient;

namespace Login_Form2.Services
{
    public class UsersDAO
    {
        string connectionString = @"Data Source=DESKTOP-IQ29TBT\SQLEXPRESS;Initial Catalog = Test1; User ID = sa; Password=********;
            Connect Timeout = 30;
        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        // retunr true if found in DB
        public bool FindUserByNameAndPassword(Models.UserModel user)
        {
            string sqlStatement = "SELECT FROM dbo.Users WHERE username=@username AND password= @password";

            //We need to make a connecion to the DB

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.Username;

                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

            }  

            
        }


    }
}
