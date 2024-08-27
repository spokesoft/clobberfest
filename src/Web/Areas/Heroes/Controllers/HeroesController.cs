using Spokesoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    /// <summary>
    /// Base controller for the accounts area.
    /// </summary>
    public class HeroesController : AppController
    {
        public const string AreaName = "Heroes";

        /// <summary>
        /// Accounts area routes
        /// </summary>
        public const string IndexRoute = "/heroes";
        public const string ProfileRoute = "/heroes/{id}";
        public const string CreateRoute = "/heroes/create";
        public const string UpdateRoute = "/heroes/{id}/update";
        public const string DeleteRoute = "/heroes/{id}";
        public const string GraveyardRoute = "/graveyard";

        protected string DefaultLayout => "Accounts/_Layout.cshtml";

        protected string ViewPath(string path)
        {
            return $"~/Areas/{AreaName}/Views/{path}";
        }
    }
}