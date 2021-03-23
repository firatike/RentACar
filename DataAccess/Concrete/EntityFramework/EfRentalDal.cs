using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cust in context.Customers
                             join ca in context.Cars
                             on cust.CustomerId equals ca.CarId
                             join u in context.Users
                             on cust.CustomerId equals u.Id
                             join b in context.Brands
                             on cust.CustomerId equals b.BrandId
                             join r in context.Rentals
                             on cust.CustomerId equals r.RentalId
                             select new RentalDetailDto
                             {
                                 RentalId = ca.CarId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate=r.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
