using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class FacultyDTO : BaseModels
    {         
        public string FacultyId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Description { get; set; }
    }
}
