using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly Baz _baz = new Baz(bar: null, foo: 1);
        private readonly IOptions<JsonOptions> _jsonOptions;

        public HomeController(IOptions<JsonOptions> jsonOptions)
        {
            _jsonOptions = jsonOptions;
        }

        [HttpGet("/objectResult")]
        public IActionResult GetObjectResult()
            => new ObjectResult(_baz);

        [HttpGet("/jsonResult")]
        public IActionResult GetJsonResult()
            => new JsonResult(_baz);

        [HttpGet("/contentResult")]
        public IActionResult GetContentResult()
            => new ContentResult()
            {
                Content = JsonSerializer.Serialize(
                    _baz,
                    _jsonOptions.Value.JsonSerializerOptions)
            };
    }
}