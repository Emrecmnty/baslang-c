using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleApp.entity;
namespace consoleApp.DataAccess.Abstract
{
    public interface IproductRepository:IRepository<product>
    {
         product [] GetProductsByCategory(int İd);

         
        
    }
}