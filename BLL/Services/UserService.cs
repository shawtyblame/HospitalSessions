using BLL.Interfaces;
using DAL.DTOS;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository; 
        public async Task<bool> Registration(UserDTO userDto)
        {
            return await _userRepository.Registration(userDto); 
        }
        public async Task<UserCredentional> Validate(string login, string password) 
        {
            return await _userRepository.Validate(login, password);        
        }
    }
}
