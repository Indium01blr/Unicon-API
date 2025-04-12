using Microsoft.AspNetCore.Mvc;
using Unicorn_Trade_api.Models;
using Newtonsoft.Json;
using System.Data;


namespace Unicorn_Trade_api.Services
{
    public class UserService: IUserService
    {
        public UserService() { }

        [HttpGet]
        public User GetUser(string name)
        {
            DBWrapper dBWrapper = new DBWrapper();
            var listOfUsers = dBWrapper.Getusers();
            List<User> userList = (from row in listOfUsers.AsEnumerable()
                                   select new User()
                                   {
                                       Name = Convert.ToString(row["Name"])
                                   }).ToList();

            User user = userList.Find(v => v.Name.Equals(name));
            return user;
        }
    }

    interface IUserService
    {
        [HttpGet]
        
        User GetUser(string name);
    }


}
