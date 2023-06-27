using BusinessLogicLayer.InterfacesBLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using User = DataTransferClasses.Classes.User;

namespace HimalayanOnlineHotelBooking.Pages.Hotel.Account
{

    public class LoginModel : PageModel
    {
        private readonly IUserBLL userBLL;
       
        public User user = new User();

        public LoginModel(IUserBLL userBLL)
        {
            this.userBLL = userBLL;
          
        }

        [BindProperty]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }


        public string ErrorMessage { get; private set; }

        public string LoggedInUsername { get; set; }

        public void OnGet()
        {

           
        }

        public IActionResult OnPost()
        {

            user.Username = Username;
            user.Password = Password;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                bool loginSuccessful = userBLL.Login(user);

                if (loginSuccessful)
                {
                    int guestId = userBLL.GetGuestIdToken(user);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,"G"),
                        new Claim("GuestId", guestId.ToString())
                    };

                    var identity = new ClaimsIdentity(claims, Username);
                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.Session.SetString("LoggedInUsername", Username);
                    HttpContext.Items["LoggedInUsername"] = Username;
                    HttpContext.Session.SetInt32("GuestId", guestId);

                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return Page();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return Page();
            }

        }

    }
    
}
