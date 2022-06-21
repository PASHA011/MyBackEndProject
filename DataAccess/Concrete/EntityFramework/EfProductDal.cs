using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.CTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetailDto()
        {
            using (NorthwindContext context= new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.ProductID equals c.CategoryID
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 UnitsInStock = p.UnitsInStock,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }

        public void Merhaba()
        {

        }
    }
}
