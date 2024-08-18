using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]     
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); // If _mnediator property is not populated We populate the IMediator with the HttpContext Service. The HttpContext is accessible from all controllers derivated from ControllerBase

    }
}