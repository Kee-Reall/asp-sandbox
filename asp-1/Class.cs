using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace asp_1
{


    [Route("blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private string[] blogs = new string[] { "Johney", "Cars", "Horney" };

        [HttpGet]
        public ActionResult<string[]> GetMany() => blogs;


        [HttpGet("{id}")]
        public ActionResult<string> GetOne(string id)
        {
            int number = -1;

            try
            {
                number = Convert.ToInt32(id);
            }
            catch
            {
                return NotFound();
            }
            if (number > blogs.Length - 1)
                return NotFound();

            return blogs[number];
        }
    }
}
