﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEquipmentDal: IEntityRepository<Equipment>
    {
        List<EquipmentDetailDto> GetEquipmentDetails(Expression<Func<Equipment,bool>> filter = null);
    }
}
