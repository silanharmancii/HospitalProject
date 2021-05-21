using Bussiness.Abstract;
using Bussiness.Constants;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class EquipmentManager : IEquipmentService
    {
        readonly IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {
            _equipmentDal = equipmentDal;
        }
       
        [ValidationAspect(typeof(EquipmentValidator))]
        public IResult Add(Equipment equipment)
        {
            _equipmentDal.Add(equipment);
            return new SuccessResult(Messages.EquipmentAdded);
        }

        public IResult Delete(Equipment equipment)
        {
            _equipmentDal.Delete(equipment);
            return new SuccessResult(Messages.EquipmentDeleted);
        }

        //[LogAspect]--AOP
        public IDataResult<List<Equipment>> GetAll()
        {
            return new SuccessDataResult<List<Equipment>>( _equipmentDal.GetAll(),Messages.EquipmentsListed);
        }

        public async Task<IDataResult<List<EquipmentDetailDto>>> GetAllAsync()
        {
            return await Task.Run(()=> {
                return new SuccessDataResult<List<EquipmentDetailDto>>( _equipmentDal.GetEquipmentDetails(),Messages.EquipmentsListed);
            });
        }

        public IDataResult<Equipment> GetById(int equipmentId)
        {
            return new SuccessDataResult<Equipment>( _equipmentDal.Get(p => p.EquipmentId == equipmentId));
        }

        public IDataResult<List<EquipmentDetailDto>> GetEquipmentDetails(int equipmentId)
        {
            return new SuccessDataResult<List<EquipmentDetailDto>>(_equipmentDal.GetEquipmentDetails(p => p.EquipmentId == equipmentId));
        }

        public async Task<IDataResult<List<EquipmentDetailDto>>> GetEquipmentDetailsAsync(int equipmentId)
        {
            return await Task.Run(() =>
            {
                return new SuccessDataResult<List<EquipmentDetailDto>>(_equipmentDal.GetEquipmentDetails(p => p.EquipmentId == equipmentId));

            });
        }

        public IDataResult<List<EquipmentDetailDto>> GetEquipments()
        {
            return new SuccessDataResult<List<EquipmentDetailDto>>( _equipmentDal.GetEquipmentDetails());
        }

        public IDataResult<List<EquipmentDetailDto>> GetEquipmentsByClinicId(int clinicId)
        {
            return new SuccessDataResult<List<EquipmentDetailDto>>(_equipmentDal.GetEquipmentDetails(p => p.ClinicId == clinicId));
        }

        public async Task<IDataResult<List<EquipmentDetailDto>>> GetEquipmentsByClinicIdAsync(int clinicId)
        {
            return await Task.Run(()=> {
                return new SuccessDataResult<List<EquipmentDetailDto>>(_equipmentDal.GetEquipmentDetails(p => p.ClinicId == clinicId));
            });
        }

        public IResult Update(Equipment equipment)
        {
            _equipmentDal.Update(equipment);
            return new SuccessResult(Messages.EquipmentUpdated);
        }
    }
}
