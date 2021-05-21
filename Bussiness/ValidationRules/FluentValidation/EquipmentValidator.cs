using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class EquipmentValidator: AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(p => p.EquipmentName).NotEmpty();
            RuleFor(p => p.UsageRate).InclusiveBetween(0, 100);
            RuleFor(p => p.ClinicId).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).NotEmpty();

        }
    }
}
