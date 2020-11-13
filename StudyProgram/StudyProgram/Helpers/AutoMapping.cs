using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StudyProgram.Models;

namespace StudyProgram.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Speciality, SpecialityDTO>();
            CreateMap<Course, CourseDTO>();
        }
    }
}
