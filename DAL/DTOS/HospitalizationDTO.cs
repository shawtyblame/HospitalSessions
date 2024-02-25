
namespace DAL.DTOS
{
    public class HospitalizationDTO
    {
        public long? PhoneNumber { get; set; }
        public int Code { get; set; }
        public string? Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Departament { get; set; }
        public DateTime DateOfHospitalization { get; set; }
        public string? HospitalizationStatus { get; set; }
    }
}
