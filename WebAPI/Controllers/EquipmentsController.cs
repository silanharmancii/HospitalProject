using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        IEquipmentService _equipmentService;

        public EquipmentsController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _equipmentService.GetAllAsync().Result;

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getequipmentdetails")]

        public IActionResult GetEquipmentDetails(int equipmentId)
        {
            var result = _equipmentService.GetEquipmentDetailsAsync(equipmentId).Result;

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getequipmentsbyclinicid")]

        public IActionResult GetEquipmentsByClinicId(int clinicId)
        {
            var result = _equipmentService.GetEquipmentsByClinicIdAsync(clinicId).Result;

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        //[Authorize()]
        public IActionResult Add(Equipment equipment)
        {
            var result = _equipmentService.Add(equipment);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]

        public IActionResult Delete(Equipment equipment)
        {
            var result = _equipmentService.Delete(equipment);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Equipment equipment)
        {
            var result = _equipmentService.Update(equipment);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
