using Newtonsoft.Json;
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
        void Import(List<Subject> models);
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
            return _context.Subject.FirstOrDefault(x => x.Id == id);
        }

        public void Import(List<Subject> models)
        {
            var listAdd = new List<Subject>();
            var listUpdate = new List<Subject>();
            foreach (var item in models)
            {
                var obj = GetById(item.Id);
                if (obj == null || item.Id == 0)
                {
                    listAdd.Add(item);
                }
                else
                {
                    var data = _context.Subject.Where(x => x.Id == item.Id).FirstOrDefault();
                    if (data != null)
                    {
                        data.NameEN = item.NameEN;
                        data.NameVN = item.NameVN;
                        listUpdate.Add(data);
                    }
                }
            }
            _context.Subject.AddRange(listAdd);
            _context.Subject.UpdateRange(listUpdate);
            _context.SaveChanges();
        }

        public void Update(Subject model)
        {

        }
    }

}
