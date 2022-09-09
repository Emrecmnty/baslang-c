using System;
using System.Globalization;
using consoleApp.DataAccess.Abstract;
using consoleApp.DataAccess.Concrete;
using consoleApp.entity;

namespace MyApp 
{
    class productManager : IproductRepository
    {   
        IproductRepository _repository;
        public productManager (IproductRepository repository)
        {
              _repository = repository;
        }
        public void crate(product entity)
        {
            _repository.crate(entity);
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


    internal class Program
    {
        static void Main(string[] args)
        { 
            var productRep = new productManager(new MySQLProductDal());
            productRep.crate(new product());
                                            
        }
    }
}







