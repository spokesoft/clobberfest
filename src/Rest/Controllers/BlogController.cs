using Microsoft.AspNetCore.Mvc;

namespace Spokesoft.Clobberfest.Rest.Controllers
{
    public class BlogController : ApiController
    {
        [Route("/api/blog")]
        public async Task<IActionResult> FindArticles()
        {
            throw new NotImplementedException();
        }
    }
}