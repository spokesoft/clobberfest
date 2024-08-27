/// <remarks>
/// User case 1: Find all models
///     GET: /api/blog/articles
/// Use case 2: Find a single model by id
///     GET: /api/blog/articles/1
/// Use case 3:
///     UPDATE: /api/blog/articles/1
///     DELETE: /api/blog/articles/1
/// </remarks>
namespace Spokesoft.Clobberfest.Rest.Models
{
    public interface IQueryModel
    {

    }

    public interface IFindQueryModel : IQueryModel
    {

    }

    public interface IFindRangeQueryModel : IQueryModel
    {

    }
}
