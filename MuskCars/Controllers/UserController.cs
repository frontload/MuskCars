using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MuskCars.Entities;
using System.Linq;
using MuskCars.BusinessLogic;

namespace MuskCars.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IEntityProvider<User> userService;

        public UserController(IEntityProvider<User> userService)
        {
            this.userService = userService;
        }

        // GET: User
        [HttpGet]
        public IEnumerable<object> Get()
            => userService.GetAll().Select(u => u.AsCustomerView());
        

        // GET: User/5
        [HttpGet("{id}", Name = "UGet")]
        public object Get(int id)
            => userService.Get(id).AsCustomerView();

        // POST: User
        [HttpPost]
        public void Post([FromBody] User value)
        {
            userService.Add(value);
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ = userService.Delete(id);
        }
    }
}
