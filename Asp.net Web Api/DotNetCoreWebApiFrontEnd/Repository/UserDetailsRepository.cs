using DotNetCoreWebApiFrontEnd.Data;
using DotNetCoreWebApiFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Repository
{
    public class UserDetailsRepository : IUserDetails
    {

        private UserManagementDbContext _userManagementDb;
        public UserDetailsRepository(UserManagementDbContext userManagementDb)
        {
            _userManagementDb = userManagementDb;
        }
        #region
        /*GetAllUserDetails
        public List<UserDetails> GetAllUserDetails()
        {
            try
            {
                List<UserDetails> user = _userManagementDb.UserDetails.ToList();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public UserDetails GetUserById(int id)
        {
            
                return _userManagementDb.UserDetails.FirstOrDefault(x => x.UserId == id);
     
        }*/
        
        public UserDetails AddUser(UserDetails user)
        {
       
                _userManagementDb.Add(user);
                _userManagementDb.SaveChanges();
                return (user);
               
            
        }


        /* public UserDetails UpdateUser(int id, UserDetails user)
{
    var details = _userManagementDb.UserDetails.FirstOrDefault(x => x.UserId == id);
    if (details == null)
    {
        return null;
    }
    details.FirstName = user.FirstName;
    details.LastName = user.LastName;
    details.Email = user.Email;
    _userManagementDb.SaveChanges();
    return details;

}
public UserDetails DeleteUser(int id)
{
      var Details1 = _userManagementDb.UserDetails.FirstOrDefault(x => x.UserId == id);
    if (Details1 == null)
    {
        return null;
    }
    _userManagementDb.UserDetails.Remove(Details1);
    _userManagementDb.SaveChanges();
    return Details1;

}
*/
        #endregion


    }
}
