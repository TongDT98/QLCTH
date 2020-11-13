using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Service
{
    public interface IReadOnlyService<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
