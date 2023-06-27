using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages.Shared
{
    public class _LoginStatusPartialModel : PageModel
    {
        public string LoggedInUsername { get; set; }
        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
        }
    }
}
