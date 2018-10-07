using NetCore_CRUD.Models.DTO;
using NetCore_CRUD.Repository.BLO;
using NetCore_CRUD.Repository.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Models.BLL
{
    public class ProductBLL:IProductBLL
    {
        private readonly IProductDAO DO =null;
        public ProductBLL(IProductDAO DO)
        {
            this.DO = DO;
        }
        public void Create(Product item)
        {
            DO.Create(item);
        }
        public void Update(Product item)
        {
            DO.Update(item);
        }
        public void Delete(Product item)
        {
            DO.Delete(item);
        }
        public IEnumerable<Product> GetAll()
        {
            return DO.GetAll();
        }
        public IEnumerable<Product> GetById(string Id)
        {
            return DO.GetAll().Where(x => x.ProductID == Id).ToList();
        }
    }
}
