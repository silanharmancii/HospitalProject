using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ClinicManager : IClinicService
    {
        IClinicDal _clinicDal;
        public ClinicManager(IClinicDal clinicDal)
        {
             _clinicDal = clinicDal;
            
        }

        public IResult Add(Clinic clinic)
        {
            _clinicDal.Add(clinic);
            return new SuccessResult(Messages.ClinicAdded);
        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccessResult(Messages.ClinicDeleted);
        }

        public IDataResult<List<Clinic>> GetAll()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(),Messages.ClinicsListed);
        }

        public async Task<IDataResult<List<Clinic>>> GetAllAsync()
        {
            return await Task.Run(()=>{
                return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(), Messages.ClinicsListed);
            });
        }

        public IDataResult<Clinic> GetById(int clinicId)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(p=>p.ClinicId==clinicId));
        }

        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccessResult(Messages.ClinictUpdated);
        }
    }
}
