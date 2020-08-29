 
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api_Layer.Controllers
{
    [Authorize]
    [Route("api")]
    [ApiController]
    public abstract class BaseController : Controller
    {
        private IMediator _mediator;
        private IConfiguration _configuration;

        protected IConfiguration Configuration => _configuration ?? (_configuration = HttpContext.RequestServices.GetService<IConfiguration>());
        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
        protected string RequestToken => HttpContext.Request.Headers["Authorization"] != "" ? HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "") : "";

        public HttpContext _requestTokenAction => HttpContext;
    }
}