using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace HimalayanOnlineHotelBooking.Pages.Hotel
{
    public class GuestsModel : PageModel
    {
        private readonly IGuestBLL guestBLL;

        public GuestsModel(IGuestBLL guestBLL)
        {
            this.guestBLL = guestBLL;
        }


        public string LoggedInUsername { get; set; }

        [BindProperty]
        public Guest Guest { get; set; }

        public string ErrorMessage { get; set; }

        public int GuestId { get; set; }

        public IActionResult OnGet(int guestId)
        {
            GuestId = guestId;

            if (GuestId != 0)
            {
                Guest = guestBLL.GetGuestDetails(GuestId);
            }

            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;

            return Page();
        }


        public IActionResult OnPost()
        {
            try
            {
                bool success = guestBLL.UpdateGuest(Guest, Request.Form["GuestId"]);

                if (success)
                {
                    ErrorMessage = "Profile updated successfully!";
                }
                else
                {
                    ErrorMessage = "Something went wrong";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "An error occurred: " + ex.Message;
            }

            return Page();

        }
    }
}
