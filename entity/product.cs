using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApp.entity
{
    public class product:IEntity
    {
        public int Id { get; set; }
        public string Name  { get; set; } = string.Empty;
        public double Price { get; set; }
        
    }
}