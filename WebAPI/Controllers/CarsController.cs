﻿using Business.Abstract;
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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetCars()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return Problem(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult GetCarById(int id)
        {
            var result = _carService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return Problem(result.Message);
        }

        [HttpPost("add")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Created("", result);
            }
            return Problem(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCar(Car car)
        {
            var result = _carService.Delete(car);
            return Ok(result);
        }

        [HttpDelete("update")]
        public IActionResult UpdateCar(Car car)
        {
            var result = _carService.Update(car);
            return Ok(result);
        }
    }
}
