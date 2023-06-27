using BusinessLogicLayer.BLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimalayanOnlineHotelBooking.Pages.Hotel.Account
{
    public class SignupModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private UserBLL userBLL;

        public SignupModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            userBLL = new UserBLL(new UserDAL());
        }



        [BindProperty]
        public Guest? Guest { get; set; }

        [BindProperty]
        public new User? User { get; set; }

        public string? LoggedInUsername { get; set; }

     

        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;

        }


        private void DisplayErrorMessage(string errorMessage)
        {
            TempData["ErrorMessage"] = errorMessage;
        }


        public IActionResult OnPost()
        {
            var guestProperties = typeof(Guest).GetProperties();
            var userProperties = typeof(User).GetProperties();

            foreach (var property in guestProperties)
            {
                var value = property.GetValue(Guest);

                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    ModelState.AddModelError($"Guest.{property.Name}", $"Please enter the {property.Name}.");
                }
            }

            foreach (var property in userProperties)
            {
                var value = property.GetValue(User);

                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    ModelState.AddModelError($"User.{property.Name}", $"Please enter the {property.Name}.");
                }
            }


            if (ModelState.IsValid)
            {
                try
                {
                    if (Guest != null && User != null)
                    {
                        var result = userBLL.InsertGuestAndLoginData(Guest, User);

                        if (result)
                        {
                            return RedirectToPage("/Hotel/Account/SuccessPage");

                        }
                        else
                        {
                            DisplayErrorMessage("Insertion failed.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    DisplayErrorMessage( ex.Message);
                }
            }

            return Page();
        }


      

    }
}
