using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class System_MasterData
    {
        public int Id { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Groupid { get; set; }
        public float Value { get; set; }
        public string Description { get; set; }
    }
}
