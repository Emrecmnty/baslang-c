using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleApp.DataAccess.Abstract;
using consoleApp.entity;
namespace consoleApp.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void crate(Category entity)
        {
            Console.WriteLine("Crated --- Category");
        }

        public void delete(Category id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}