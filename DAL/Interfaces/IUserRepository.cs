using DAL.DTOS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        public Task<bool> Registration(UserDTO userDto);
        public Task<UserCredentional> Validate(string login, string password);
    }
}
