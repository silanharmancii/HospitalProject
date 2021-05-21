using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussiness.Abstract
{
    public interface IEquipmentService
    {
        IDataResult<List<Equipment>> GetAll();
        IDataResult<Equipment> GetById(int equipmentId);
        IDataResult<List<EquipmentDetailDto>> GetEquipments();
        IDataResult<List<EquipmentDetailDto>> GetEquipmentDetails(int equipmentId);
        IDataResult<List<EquipmentDetailDto>> GetEquipmentsByClinicId(int clinicId);
        Task<IDataResult<List<EquipmentDetailDto>>> GetEquipmentDetailsAsync(int equipmentId);
        Task<IDataResult<List<EquipmentDetailDto>>> GetEquipmentsByClinicIdAsync(int clinicId);
        Task<IDataResult<List<EquipmentDetailDto>>> GetAllAsync();
        IResult Add(Equipment equipment);
        IResult Update(Equipment equipment);
        IResult Delete(Equipment equipment);

    }
}
