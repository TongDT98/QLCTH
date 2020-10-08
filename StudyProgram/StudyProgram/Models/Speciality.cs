using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Speciality: BaseModels
    {   
        public string SpecialityId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Desciption { get; set; }

    }
}
