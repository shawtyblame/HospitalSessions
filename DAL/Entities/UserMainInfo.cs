using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserMainInfo  : EntityBase
    {
        public string? Name { get; set; }
        public string? Surname { get; set;}
        public string? LastName { get; set; }
        public long PassportSeries { get; set; }
        public long PassportNumber { get; set; }
        public int GenderId { get;set; }
        [JsonIgnore]
        public Gender? Gender { get; set; } 
        public long PhoneNumber { get; set; }
        public string? Email { get; set; } 
        public int UserCredentionalId { get; set; }
        [JsonIgnore]
        public UserCredentional? UserCredentional { get; set; }

    }
}
