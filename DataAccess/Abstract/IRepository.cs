using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApp.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
         TEntity GetById (int id);
         void update (TEntity entity);
        
          void crate (TEntity entity);
       
          void delete (TEntity id);
        
    }
}