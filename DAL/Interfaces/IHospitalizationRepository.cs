using DAL.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IHospitalizationRepository
    {
        public Task<bool> SendToHospitalizaiton(HospitalizationDTO hospitalizationDTO);
    }
}
