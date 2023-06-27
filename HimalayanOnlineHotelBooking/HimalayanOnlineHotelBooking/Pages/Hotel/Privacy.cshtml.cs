using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string LoggedInUsername { get; set; }

        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;
        }
    }
}