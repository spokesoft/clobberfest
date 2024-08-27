namespace Spokesoft.Clobberfest.Web.Models
{
    public class ViewModel
    {
        public virtual string Title { get; set; } = "Clobberfest";

        public NavbarModel Navbar { get; set; } = new NavbarModel();
    }
}