using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Models.DTO
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public int UnitsInStock { get; set; }
        
    }
}
