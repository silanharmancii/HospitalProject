using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IClinicService
    {
        Task<IDataResult<List<Clinic>>> GetAllAsync();
        IDataResult<List<Clinic>> GetAll();
        IDataResult<Clinic> GetById(int clinicId);
        IResult Add(Clinic clinic);
        IResult Update(Clinic clinic);
        IResult Delete(Clinic clinic);
    }
}
