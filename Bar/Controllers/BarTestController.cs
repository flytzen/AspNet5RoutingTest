namespace Bar.Controllers
{
    using Microsoft.AspNet.Mvc;

    public class BarTestController : Controller
    {
        [Route("bar/test")]
        public ActionResult Index()
        {
            return new ObjectResult(new
                                        {
                                            from = "the bar test controller"
                                        });
        }
         
    }
}