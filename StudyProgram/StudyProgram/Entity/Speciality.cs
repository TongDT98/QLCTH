﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Speciality:BaseEntity
    {
        public string SpecialityId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public int Credit { get; set; }
        public string Desciption { get; set; }
    }
}
