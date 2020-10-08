using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class User_Detail: BaseModels
    {
     
        public string UserId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StreetName { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public string Zipcode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
