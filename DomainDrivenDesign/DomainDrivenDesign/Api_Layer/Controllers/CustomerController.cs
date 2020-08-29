using Application_Layer.Context.Customer.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api_Layer.Controllers
{
    public class CustomerController : AuthBaseController
    {
        [HttpGet("test")]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetCustomerListQuery()));
        }
    }
}