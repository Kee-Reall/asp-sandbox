using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BlogPlatform.Controllers
{


    [Route("blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private string[] blogs = new string[] { "Johney", "Cars", "Horney" };

        [HttpGet]
        public ActionResult<string[]> GetMany() => blogs;


        [HttpGet("{id}")]
        public ActionResult<string> GetOne(string id) => blogs[1];        

        [HttpPost]
        public ActionResult<IBlogInput> Create([FromBody]BlogInput inputBlog)
        {
            return inputBlog;
        }
    }
}
