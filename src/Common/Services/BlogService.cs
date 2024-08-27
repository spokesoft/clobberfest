using Spokesoft.Clobberfest.Data.Models.Blog;

namespace Spokesoft.Clobberfest.Common.Services
{
    public interface IBlogService
    {
    }

    public partial class BlogService(IBlogArticlesService blogArticlesService)
    {
        public readonly IBlogArticlesService Articles = blogArticlesService;

        public async Task<IEnumerable<Article>> FindAllArticlesAsync()
        {
            return await Articles.FindRangeAsync();
        }
    }

    // public class BlogService : IBlogService
    // {

    // }
}