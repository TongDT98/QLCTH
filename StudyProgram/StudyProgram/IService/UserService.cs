using StudyProgram.DataContext;
using StudyProgram.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Service
{
    public interface IUserService : IReadOnlyService<User>
    {
        User Create(User model);
        void Update(User model);
    }
    public class UserService : IUserService
    {



        private readonly SPMContext _context;
        public UserService(SPMContext context)
        {
            _context = context;
        }
        public User Create(User model)
        {
            if (string.IsNullOrEmpty(model.UserName))
                throw new Exception("khong dc de trong ");
            model.Isdeleted = false;
            _context.User.Add(model);
            _context.SaveChanges();
            return model;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }

        User IUserService.Create(User model)
        {
            throw new NotImplementedException();
        }
    }


}
