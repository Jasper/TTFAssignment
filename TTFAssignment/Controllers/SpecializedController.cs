using Assignment.Mapping;
using Assignment.Models;
using Assignment.SpecializedOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace TTFAssignment.Controllers
{
    [RoutePrefix("specialized")]
    public class SpecializedController : ApiController
    {
        [HttpGet]
        [Route("one")]
        public HttpResponseMessage One([FromUri] Input input)
        {
            SpecializedOne specializedOneMapper = new SpecializedOne(input);
            Output output = specializedOneMapper.getResult();

            if (output != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, output);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "error");
            }
        }

        [HttpGet]
        [Route("two")]
        public HttpResponseMessage Two([FromUri] Input input)
        {

            SpecializedTwo specializedTwoMapper = new SpecializedTwo(input);
            Output output = specializedTwoMapper.getResult();

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
