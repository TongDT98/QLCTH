using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using StudyProgram.DataContext;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using StudyProgram.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudyProgram.Service
{
    interface ISpecialityService : IReadOnlyService<Speciality>
    {
        List<SelectListItem> GetSpecialitiesByCourseId(string courseId);
        Speciality Create(Speciality model);
        void Update(Speciality model);
    }
    public class SpecialityService : ISpecialityService
    {
        private readonly SPMContext _context;
        public SpecialityService(SPMContext context)
        {
            _context = context;
        }
        public Speciality Create(Speciality model)
        {
            if (string.IsNullOrEmpty(model.NameVN))
                throw new Exception("khong dc de trong NameVN");
            model.Isdeleted = false;
            _context.Speciality.Add(model);
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<Speciality> GetAll()
        {
            return _context.Speciality;
        }

        public Speciality GetById(int id)
        {
            return _context.Speciality.FirstOrDefault(x => x.Id == id);
        }

        public List<SelectListItem> GetSpecialitiesByCourseId(string courseId)
        {
            if (!string.IsNullOrEmpty(courseId))
            {
                List<SelectListItem> specialities = new List<SelectListItem>();
                var specialityIds = _context.Course_Speciality_Mapping.Where(x => x.CourseId == courseId)
                    .Select(x => x.SpecialityId).ToList();
                if (specialityIds.Any())
                {
                    for (var item = 0; item < specialityIds.Count; item++)
                    {
                        var speciality = _context.Speciality.Where(x => x.SpecialityId == specialityIds[item]).Select(s => new SelectListItem()
                        {
                            Value = s.SpecialityId ?? s.NameVN,
                            Text = s.SpecialityId ?? s.NameVN
                        }).FirstOrDefault();
                        specialities.Add(speciality);
                    }
                }
                return specialities;
            }

            return null;
        }

        public void Update(Speciality model)
        {

        }
    }
}
