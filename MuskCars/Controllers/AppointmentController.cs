using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MuskCars.BusinessLogic;
using MuskCars.Entities;

namespace MuskCars.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly ApptBL apptService;

        public AppointmentController(ApptBL apptService)
        {
            this.apptService = apptService;
        }

        // GET: CarWorkshop
        [HttpGet]
        public IEnumerable<object> Get()
            => apptService.GetAll().Select(a => a.AsCustomerView());


        // GET: CarWorkshop/5
        [HttpGet("{id}", Name = "AGet")]
        public object Get(int id)
            => apptService.Get(id).AsCustomerView();

        // POST: CarWorkshop
        [HttpPost]
        public void Post([FromBody] Appointment value)
        {
            apptService.Add(value);
        }

        // DELETE: CarWorkshop/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ = apptService.Delete(id);
        }

        // PATCH: CarWorkshop/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] Appointment value)
        {
            apptService.UpdateTime(id, value.Time);
        }

    }
}
