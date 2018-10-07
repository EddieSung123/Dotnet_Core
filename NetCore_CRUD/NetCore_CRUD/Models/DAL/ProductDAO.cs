using Microsoft.EntityFrameworkCore;
using NetCore_CRUD.Models.DTO;
using NetCore_CRUD.Repository.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Models.DAL
{
    public class ProductDAO:IProductDAO, IDisposable
    {
        private DbContext EF = null;
        public ProductDAO(DbContext EF)
        {
            try
            {
                if(this.EF == null)
                {
                    this.EF = EF;
                }
            }
            catch(Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public void Create(Product item)
        {
            try
            {
                if(item == null)
                {
                    throw new ArgumentNullException("item");
                }
                else
                {
                    item.ProductID = Guid.NewGuid().ToString();
                    EF.Set<Product>().Add(item); //_EF.Entry(item).State = EntityState.Added;
                    EF.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public void Update(Product item)
        {
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                else
                {
                    EF.Entry(item).State = EntityState.Modified;
                    EF.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }
        }

        public void Delete(Product item)
        {
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                else
                {
                    EF.Entry(item).State = EntityState.Deleted;
                    EF.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return EF.Set<Product>().ToList();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public IEnumerable<Product> GetById(string Id)
        {
            try
            {
                if(Id == "")
                {
                    return EF.Set<Product>().Take(200).ToList();
                }
                return EF.Set<Product>().Where((x) => x.ProductID == Id).ToList();
            }
            catch (Exception ex)
            {

                throw new NotImplementedException(ex.Message);
            }
        }
        
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    EF.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        
    }
}
