using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class User:BaseEntity
    {
      
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }
    }
}
