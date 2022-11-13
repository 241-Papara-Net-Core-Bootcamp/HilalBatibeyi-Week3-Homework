using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            _carService.Add(car);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            _carService.Delete(car);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Car car)
        {
            _carService.Update(car);
            return Ok();
        }
    }
}
