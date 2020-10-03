using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Description { get; set; }
    }
}
