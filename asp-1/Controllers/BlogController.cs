using asp_1.Entity;
using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Controllers
{


    [Route("blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private BlogEntity[] blogs = new BlogEntity[] 
        { 
            new BlogEntity("Johney", "nothing", "string.com"),
            new BlogEntity("Carl", "Sobmreara", "kaspi.kz"),
            new BlogEntity("Alex", "Vodka", "google.net")
        };

        [HttpGet]
        public ActionResult<BlogEntity[]> GetMany() => blogs;


        [HttpGet("{id}")]
        public ActionResult<BlogEntity> GetOne(int id) => blogs[id];        

        [HttpPost]
        public ActionResult<IBlogInput> Create([FromBody]BlogInput inputBlog)
        {
            return inputBlog;
        }
    }
}
