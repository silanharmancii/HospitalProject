using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEquipmentDal : EfEntityRepositoryBase<Equipment, HospitalContext>, IEquipmentDal
    {
        public List<EquipmentDetailDto> GetEquipmentDetails(Expression<Func<Equipment, bool>> filter = null)
        {
            
            using(HospitalContext context = new HospitalContext())
            {
                var result = from e in filter == null? context.Equipments : context.Equipments.Where(filter)
                             join c in context.Clinics
                             on e.ClinicId equals c.ClinicId
                             select new EquipmentDetailDto
                             {
                                 EquipmentId = e.EquipmentId,
                                 ClinicName = c.ClinicName,
                                 EquipmentName = e.EquipmentName,
                                 ProcurementDate=e.ProcurementDate,
                                 UnitsInStock = e.UnitsInStock,
                                 UnitPrice = e.UnitPrice,
                                 UsageRate = e.UsageRate
                             };
                return result.ToList();
            }
        }
    }
}
