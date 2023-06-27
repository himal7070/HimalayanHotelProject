using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages.Hotel
{
    public class AboutUsModel : PageModel
    {
        public string LoggedInUsername { get; set; }
        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
        }
    }
}
