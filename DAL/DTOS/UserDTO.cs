

namespace DAL.DTOS
{
     public class UserDTO
    {
        public string? Login {  get; set; }
        public string? Password { get; set; }
        public DateTime DateOfBirth { get; set;     } 
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? LastName { get; set; }
        public long PassportSeries { get; set; }
        public long PassportNumber { get; set; }
        public string? Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? WorkPlace { get; set; }
        public long? InsurancePolicyNumber { get; set; }
        public DateTime InsurancePolicyNumberEndDate { get; set; }
    }
}
