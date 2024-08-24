using Spokesoft.Clobberfest.Data.Models.Blog;

namespace Spokesoft.Clobberfest.Web.Areas.Blog.Models
{
    public class IndexViewModel : BlogViewModel
    {
        public string SearchTerm { get; set; } = "";

        public ICollection<Article> Articles { get; set; } = [];
    }
}