using Assignment.Mapping;
using Assignment.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TTFAssignment.Controllers
{
    [RoutePrefix("base")]
    public class BaseController : ApiController
    {
        public BaseController()
        {
        }

        [HttpGet]
        [Route("")]
        public HttpResponseMessage Index([FromUri] Input input)
        {
            BaseMapping baseMapper = new BaseMapping(input);
            Output output = baseMapper.getResult();

            if (output != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, output);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "error");
            }
        }
    }
}
