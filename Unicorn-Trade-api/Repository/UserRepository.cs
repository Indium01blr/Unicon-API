
using Unicorn_Trade_api.Services;
using System.Data;
using MySqlConnector;

namespace Unicorn_Trade_api.Repository
{
    public class UserRepository(DBWrapper dBWrapper)
    {
        

        public DataTable  GetUsers()
        {
            DBWrapper wrapper = new DBWrapper();

            DataTable  response = wrapper.Getusers();
            return response;

        }
    }
}
