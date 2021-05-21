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
    public class ClinicsController : ControllerBase
    {
        IClinicService _clinicService;

        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _clinicService.GetAll();

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getclinicdetails")]

        public IActionResult GetClinicDetails(int clinicId)
        {
            var result = _clinicService.GetById(clinicId);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }     

        [HttpPost("add")]
        //[Authorize()]
        public IActionResult Add(Clinic clinic)
        {
            var result = _clinicService.Add(clinic);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]

        public IActionResult Delete(Clinic clinic)
        {
            var result = _clinicService.Delete(clinic);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Clinic clinic)
        {
            var result = _clinicService.Update(clinic);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
