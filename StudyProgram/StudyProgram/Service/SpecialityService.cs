using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using StudyProgram.DataContext;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Service
{
    interface ISpecialityService  : IReadOnlyService<Speciality>
    {
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

        public void Update(Speciality model)
        {

        }
    }
}
