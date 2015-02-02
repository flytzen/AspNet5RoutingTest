namespace Api.Controllers
{
    using Microsoft.AspNet.Mvc;

    public class ApiTestController : Controller
    {
        [Route("api/test")]
        public ActionResult Index()
        {
            return new ObjectResult(new
                                        {
                                            from = "the api test controller"
                                        });
        }
         
    }
}