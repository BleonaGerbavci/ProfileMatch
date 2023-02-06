using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public int Id { get; private set; }

        public void AddUser(UserVM user)
        {
            var _user = new User()
            {
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt,
                VerificationToken = user.VerificationToken,
                PasswordResetToken = user.PasswordResetToken,
                ResetTokenExpires = user.ResetTokenExpires
            };
            _context.Users.Add(_user);
            _context.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            var _user = _context.Drejtori.FirstOrDefault(e => e.Id == Id);
            if (_user != null)
            {
                _context.Drejtori.Remove(_user);
                _context.SaveChanges();
            }
        }

    public User UpdateUser(int userId, UserVM user)
    {
        var _user = _context.Drejtori.FirstOrDefault(e => e.Id == Id);
        if (_user != null)
        {

            _user.Email = user.Email;
            _user.PasswordHash = user.PasswordHash;
            _user.PasswordSalt = user.PasswordSalt;
            _user.VerificationToken = user.VerificationToken;
            _user.PasswordResetToken = user.PasswordResetToken;
            _user.ResetTokenExpires = user.ResetTokenExpires;

            _context.SaveChanges();
        }
        return _user;
    }

        public User UserById(int Id)
    {
        return _context.Drejtori.FirstOrDefault(d => d.Id == Id);
    }

        
    }
}
