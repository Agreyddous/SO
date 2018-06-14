using Microsoft.AspNetCore.Mvc;

namespace Real.Api.Controllers
{
    public class PersonController : Controller
    {
        public PersonController() { }

        [HttpGet]
        [Route("")]
        [ResponseCache(Duration = 15)]
        public string Get() => "Está funcionando.";
    }
}