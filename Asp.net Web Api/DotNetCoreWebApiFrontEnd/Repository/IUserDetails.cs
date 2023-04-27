using DotNetCoreWebApiFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Repository
{
    public interface IUserDetails
    {
       // List<UserDetails> GetAllUserDetails();
       // UserDetails GetUserById(int id);
        UserDetails AddUser(UserDetails user);
       // UserDetails UpdateUser(int id, UserDetails user);
       // UserDetails DeleteUser(int id);


    }
}
