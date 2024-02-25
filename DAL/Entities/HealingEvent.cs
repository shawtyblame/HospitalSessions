using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class HealingEvent : EntityBase
    {
        public string? Name { get; set; }
        public DateTime Time { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int HealingEventTypeId { get; set; }
        [JsonIgnore]
        public HealingEventType? HealingEventType { get; set; }
        public string? Results { get; set; }
        public string? Recommeandations { get; set; }
        public int RequestVisitId {  get; set; }
        [JsonIgnore]
        public RequestVisit? RequestVisit { get; set; }
        public float Price { get; set; }
    }
}

