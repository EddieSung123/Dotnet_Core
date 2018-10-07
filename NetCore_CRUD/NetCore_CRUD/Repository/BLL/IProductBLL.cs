using NetCore_CRUD.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Repository.BLO
{
   public interface IProductBLL
   {
        void Create(Product item);
        void Update(Product item);
        void Delete(Product item);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetById(string Id);
    }
}
