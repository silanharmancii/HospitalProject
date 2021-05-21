using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EquipmentDetailDto: IDto
    {
        public int EquipmentId { get; set; }
        public string ClinicName { get; set; }
        public string EquipmentName { get; set; }
        public DateTime? ProcurementDate { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UsageRate { get; set; }
    }

}
