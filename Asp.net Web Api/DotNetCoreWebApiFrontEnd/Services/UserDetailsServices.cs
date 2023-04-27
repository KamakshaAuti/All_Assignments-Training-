using DotNetCoreWebApiFrontEnd.Model;
using DotNetCoreWebApiFrontEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Services
{
    public class UserDetailsServices
    {
        private IUserDetails _userDetailsRepository;

        public UserDetailsServices(IUserDetails  userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;
        }

       /* public List<UserDetails> GetAllUserDetails()
        {
            return _userDetailsRepository.GetAllUserDetails();
        }
        public UserDetails GetUserById(int id)
        {
            return _userDetailsRepository.GetUserById(id);

        }*/
        public UserDetails AddUser(UserDetails user)
        {
            return _userDetailsRepository.AddUser(user);

        }
       /* public UserDetails UpdateUser(int id, UserDetails user)
        {
            return _userDetailsRepository.UpdateUser(id, user);
        }
        public UserDetails DeleteUser(int id)
        {
            return _userDetailsRepository.DeleteUser(id);
        }*/
    }
}
