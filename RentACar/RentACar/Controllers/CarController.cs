using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.DAL.Repositories;
using RentACar.DAL.Requests;
using RentACar.DAL.ViewModels;

namespace RentACar.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly IBaseRepository<CarViewModel,CarUpsertRequest> _carRepository;

        public CarController(IBaseRepository<CarViewModel, CarUpsertRequest> carRepository)
        {
            _carRepository = carRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _carRepository.GetAll();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var car = await _carRepository.GetById(id);
            return Ok(car);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CarUpsertRequest req)
        {

            int id=await _carRepository.Save(req);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,[FromBody]CarUpsertRequest req)
        {

            await _carRepository.Update(id,req);
            return Ok(id);
        }

    }
}