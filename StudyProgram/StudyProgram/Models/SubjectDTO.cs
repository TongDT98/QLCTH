using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class SubjectDTO: BaseModels
    {      
        public string SubjectId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public int Creadit { get; set; }
        public string Description { get; set; }
    }
}
