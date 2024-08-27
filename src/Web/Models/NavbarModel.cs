namespace Spokesoft.Clobberfest.Web.Models
{
    /// <summary>
    /// Navbar model for the application.
    /// </summary>
    public class NavbarModel
    {
        public const string BrandText = "Clobberfest";
        public const string BrandHref = "/";
        public const string LoginText = "Login";
        public const string LoginHref = "/login";
        public const string LogoutText = "Logout";
        public const string LogoutHref = "/logout";
        public const string ProfileText = "Profile";
        public const string ProfileHref = "/profile";
        public const string RegisterText = "Register";
        public const string RegisterHref = "/register";

        public bool IsAuthenticated { get; set; } = false;
        public string UserDisplayName { get; set; } = "fakeuser@domain.com";
    }
}