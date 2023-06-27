using HimalayanOnlineHotelBooking.Pages.Hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages
{
    public class IndexModel : PageModel
    {
        public string LoggedInUsername { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
        }
    }
}