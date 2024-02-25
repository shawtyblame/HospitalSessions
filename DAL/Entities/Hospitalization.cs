using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Hospitalization : EntityBase
    {
        public int UserMainInfoId { get; set; }
        [JsonIgnore]
        public UserMainInfo? UserMainInfo { get; set; }
        public long? Code { get; set; }
        public string? Target { get; set; }
        public string? Diagnosis { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateOfHospitalization { get; set; }
        public int DepartamentId { get; set; }
        [JsonIgnore]
        public Department? Department { get; set; } 
        public int HospitalizationConditionId { get; set; }
        [JsonIgnore]
        public HospitalizationCondition? HospitalizationConditon { get; set; }
        public int HospitalizationStatusId { get; set; }
        [JsonIgnore]
        public HospitalizationStatus? HospitalizationStatus { get; set; } 
    }
}
    