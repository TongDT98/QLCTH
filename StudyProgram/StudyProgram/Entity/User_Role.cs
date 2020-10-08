using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class User_Role:BaseEntity
    {
        
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
