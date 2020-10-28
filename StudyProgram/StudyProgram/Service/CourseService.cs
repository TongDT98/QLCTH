using StudyProgram.DataContext;
using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Service
{
     interface ICourseService : IReadOnlyService<Course>
    {
        Course Create(Course model);
        void Update(Course model);
    }
    public class CourseService : ICourseService
    {
        private readonly SPMContext _context;
        public CourseService(SPMContext context)
        {
            _context = context;
        }
        public Course Create(Course model)
        {
            if (string.IsNullOrEmpty(model.CourseId))
                throw new Exception("không để trống mã khóa ");
            model.Isdeleted = false;
            _context.Course.Add(model);
            _context.SaveChanges();
            return model;
        }
        public IEnumerable<Course>GetAll()
        {
            return _context.Course;
        }
        public Course GetById(int id)
        {
            return _context.Course.FirstOrDefault(x => x.Id == id);
        }
        public void Update(Course model)
        {

        }
    }
}
