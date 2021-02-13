using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Bir iş sınıfı başka sınıfları newlemez.Bu yüzden böyle çağırırız.
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            return _ProductDal.GetAll();
        }
    }
}
