using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleApp.DataAccess.Abstract;
using consoleApp.entity;

namespace consoleApp.DataAccess.Concrete
{
    public class EfProductDal : IproductRepository
    {
        public void crate(product entity)
        {
            Console.WriteLine("Crated --- Product");
        }

        public void delete(product id)
        {
            throw new NotImplementedException();
        }

        public product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public product[] GetProductsByCategory(int İd)
        {
            throw new NotImplementedException();
        }

        public void update(product entity)
        {
            throw new NotImplementedException();
        }
    }
}