using DataAccess.Abstract;
using Entities.Concrete;
using Entities.CTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;    
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product
                {
                    CategoryID=1,ProductID=1,ProductName="bardak",UnitPrice=10,UnitsInStock=10
                },
                 new Product
                {
                    CategoryID=2,ProductID=2,ProductName="kamera",UnitPrice=20,UnitsInStock=20
                },
                  new Product
                {
                    CategoryID=3,ProductID=3,ProductName="telefon",UnitPrice=30,UnitsInStock=30
                },
                   new Product
                {
                    CategoryID=4,ProductID=4,ProductName="klavye",UnitPrice=40,UnitsInStock=40
                },
                    new Product
                {
                    CategoryID=5,ProductID=5,ProductName="fare",UnitPrice=50,UnitsInStock=50
                }

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =    _products.First(p=>p.ProductID==product.ProductID);
            _products.Remove(productToDelete);
        }


        public List<Product> GetAll()
        {
            return _products;
        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryID(int categoryID)
        {
          return  _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.First(p => p.ProductID == product.ProductID);
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductID = product.ProductID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<ProductDetailDto> GetProductDetailDto()
        {
            throw new NotImplementedException();
        }
    }
}
