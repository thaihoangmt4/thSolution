using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using thSolution.API.Model;
using thSolution.Service.Enum;

namespace thSolution.API.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult OkResult(object value, MessageCode code = MessageCode.SUCCESS, string message = "")
        {
            var rs = new HttpResponseModel((int)code, value, message);
            return new ObjectResult(rs)
            {
                StatusCode = (int)HttpStatusCode.OK
            };
        }

        protected Task<IActionResult> OkResultAsync(object value, MessageCode code = MessageCode.SUCCESS, string message = "")
        {
            return Task.FromResult(OkResult(value, code, message));
        }

        protected IActionResult NotFoundResult()
        {
            var rs = new HttpResponseModel((int)HttpStatusCode.NotFound, null, "NotFound");
            return new ObjectResult(rs)
            {
                StatusCode = (int)HttpStatusCode.NotFound
            };
        }

        protected Task<IActionResult> NotFoundResultAsync()
        {
            return Task.FromResult(NotFoundResult());
        }

        protected IActionResult BadRequestResult(object error)
        {
            var rs = new HttpResponseModel((int)HttpStatusCode.BadRequest, error, "BadRequest");
            return new ObjectResult(rs)
            {
                StatusCode = (int)HttpStatusCode.BadRequest
            };
        }

        protected Task<IActionResult> BadRequestResultAsync(object error)
        {
            return Task.FromResult(BadRequestResult(error));
        }

        protected IActionResult ForbiddenResult()
        {
            var rs = new HttpResponseModel((int)HttpStatusCode.Forbidden, null, "Forbidden");
            return new ObjectResult(rs)
            {
                StatusCode = (int)HttpStatusCode.Forbidden
            };
        }

        protected Task<IActionResult> ForbiddenResultAsync()
        {
            return Task.FromResult(ForbiddenResult());
        }
    }
}
