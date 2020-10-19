using StudyProgram.DataContext;
using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudyProgram.Service
{
    public interface ISubjectService : IReadOnlyService<Subject>
    {
        Subject Create(Subject model);
        void Update(Subject model);
    }
    public class SubjectService : ISubjectService
    {



        private readonly SPMContext _context;
        public SubjectService(SPMContext context)
        {
            _context = context;
        }
        public Subject Create(Subject model)
        {
            if (string.IsNullOrEmpty(model.NameVN))
                throw new Exception("khong dc de trong NameVN");
            model.Isdeleted = false;
            _context.Subject.Add(model);
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subject;
        }

        public Subject GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject model)
        {
            throw new NotImplementedException();
        }
    }

}
