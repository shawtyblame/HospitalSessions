using DAL.Data;
using DAL.DTOS;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Respositories
{
    public class HospitalizationRepository(AppDbContext _context) : IHospitalizationRepository
    {
        public async Task<bool> SendToHospitalizaiton(HospitalizationDTO hospitalizationDTO)
        {
            var patient = await _context.UserMainInfos.FirstOrDefaultAsync(u => u.PhoneNumber == hospitalizationDTO.PhoneNumber);
            if (patient != null)
            {
                Random random = new Random();
                Hospitalization hosp = new Hospitalization()
                { 
                    
                };
                return true;
            }
            else
            {
                throw new ArgumentException("User Not Found");
            }
        }
    }
}
