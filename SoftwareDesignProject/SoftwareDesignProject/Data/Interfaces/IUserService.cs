using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IUserService
    {
       
        public User UserById(int Id);
   
        //public User RegisterUser(User user);
        //public User LoginUser(User user);
        //public User VerifyUser(User user);
        void AddUser(UserVM user);
        void DeleteUser(int id);
        void UpdateUser(int userId, UserVM user);
    }
}
