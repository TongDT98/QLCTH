using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Subject:BaseEntity
    {
        public string SubjectId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Description { get; set; }
    }
}
