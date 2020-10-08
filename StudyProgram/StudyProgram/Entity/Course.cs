using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Course:BaseEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
