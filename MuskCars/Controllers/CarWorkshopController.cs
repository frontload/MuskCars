using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MuskCars.BusinessLogic;
using MuskCars.Entities;

namespace MuskCars.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarWorkshopController : ControllerBase
    {
        private readonly IEntityProvider<CarWorkshop> carWorkshopService;

        public CarWorkshopController(IEntityProvider<CarWorkshop> carWorkshopService)
        {
            this.carWorkshopService = carWorkshopService;
        }

        // GET: CarWorkshop
        [HttpGet]
        public IEnumerable<object> Get()
            => carWorkshopService.GetAll().Select(c => c.AsCustomerView());

        // GET: CarWorkshop/city/5
        [HttpGet("city/{id}", Name = "CWCGet")]
        public IEnumerable<dynamic> GetInCity(int id)
            => carWorkshopService.GetAll().Where(c=>c.City_Id == id).Select(c => c.AsCustomerView());

        // GET: CarWorkshop/5
        [HttpGet("{id}", Name = "CWGet")]
        public CarWorkshop Get(int id)
            => carWorkshopService.Get(id).AsCustomerView();

        // POST: CarWorkshop
        [HttpPost]
        public void Post([FromBody] CarWorkshop value)
        {
            carWorkshopService.Add(value);
        }

        // DELETE: CarWorkshop/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            carWorkshopService.Delete(id);
        }
    }
}
