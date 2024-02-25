using DAL.Data;
using DAL.DTOS;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Respositories
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _context = context;
        public async Task<bool> Registration(UserDTO userDto)
        {
            var user = await _context.UserMainInfos.FirstOrDefaultAsync(u => u.PhoneNumber == userDto.PhoneNumber);
            var gender = await _context.Genders.FirstOrDefaultAsync(g => g.Name.ToLower() == userDto.Gender.ToLower());
            if (gender != null)
            {
                if (user == null)
                {   
                    UserCredentional userCredentional = new UserCredentional()
                    {
                        Login = userDto.Login,
                        Password = userDto.Password,
                        RoleId = 3,
                        
                    };

                    _context.UserCredentionals.Add(userCredentional);
                    _context.SaveChanges();
                    var userCredInfo = await _context.UserCredentionals.FirstOrDefaultAsync(u => u.Login == userDto.Login);
                    UserMainInfo userMain = new UserMainInfo()
                    {
                        Name = userDto.Name,
                        LastName = userDto.LastName,
                        Surname = userDto.Surname,
                        PassportNumber = userDto.PassportNumber,
                        PassportSeries = userDto.PassportSeries,
                        GenderId = gender.Id,
                        PhoneNumber = userDto.PhoneNumber,
                        Email = userDto.Email,
                        UserCredentionalId = userCredentional.Id,
                    };
                    _context.UserMainInfos.Add(userMain);
                    _context.SaveChanges();
                    var userMainInfo = await _context.UserMainInfos.FirstOrDefaultAsync(u => u.PhoneNumber == userDto.PhoneNumber);
                    UserAddictional userAddictional = new UserAddictional()
                    {
                        DateTime = DateTime.UtcNow,
                        Address = userDto.Address,
                        WorkPlace = userDto.WorkPlace,
                        InsurancePolicyNumber = userDto.InsurancePolicyNumber, 
                        InsurancePolicyNumberEndDate = userDto.InsurancePolicyNumberEndDate,
                        UserMainInfoId = userMainInfo.Id
                    };
                    _context.UserAddictionals.Add(userAddictional);
                    await _context.SaveChangesAsync(); 

                    return true;
                }
                else
                {
                    throw new Exception("Already Exist");
                }
            }
            else
            {
                throw new ArgumentException("Gender Not Found");
            }
            
        }

        public async Task<UserCredentional> Validate(string login, string password)
        {
            var user = await _context.UserCredentionals.FirstOrDefaultAsync(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User Not Found");
            }
        }
    }
}
