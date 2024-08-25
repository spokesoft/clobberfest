using Spokesoft.Clobberfest.Data.Models.Blog;

namespace Spokesoft.Clobberfest.Common.Services
{
    public interface IBlogArticlesService : IEntityService<Article, long>
    {
    }

    public partial class BlogArticlesService : EntityService<Article, long>, IBlogArticlesService
    {
        
    }
}