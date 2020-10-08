using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class System_MasterData:BaseEntity
    {
       
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Groupid { get; set; }
        public float Value { get; set; }
        public string Description { get; set; }
    }
}
