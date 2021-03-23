using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand;
        public InMemoryBrandDal()
        {
            _brand = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Buick"},
            };
        }
        public void Add(Brand entity)
        {
            _brand.Add(entity);
        }

        public void Delete(Brand entity)
        {
            Brand brandToDelete = _brand.SingleOrDefault(c => c.BrandId == entity.BrandId);
            _brand.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            Brand brandUpdate = _brand.SingleOrDefault(c => c.BrandId == entity.BrandId);
            brandUpdate.BrandName = entity.BrandName;
        }
    }
}
