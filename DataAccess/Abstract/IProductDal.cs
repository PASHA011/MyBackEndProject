
using Core.DataAccess;
using Entities.Concrete;
using Entities.CTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetailDto();
    }
}
