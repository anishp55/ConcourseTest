using Microsoft.AspNetCore.Mvc;

namespace ConcourseTest 
{
	[Route("/")]
    public class TestController : Controller 
    {
		[HttpGet]
		public virtual IActionResult Index() 
		{
            return this.Ok("OK");
        }        
    }
}
