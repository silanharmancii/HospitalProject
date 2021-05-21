using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Equipment:IEntity
    {
        public int EquipmentId { get; set; }
        public int ClinicId { get; set; }
        public string EquipmentName { get; set; }
        public DateTime? ProcurementDate { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UsageRate { get; set; }


    }
}
