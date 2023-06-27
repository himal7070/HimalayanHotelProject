using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HimalayanOnlineHotelBooking.Pages.Hotel
{
    public class ContactUsModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

        public string LoggedInUsername { get; set; }

        public string ErrorMessage { get; set; }


        public void OnGet()
        {
            LoggedInUsername = HttpContext.Session.GetString("LoggedInUsername") ?? string.Empty;

        }

        public IActionResult OnPost()
        {

            try
            {
                //composing the SMS message
                string messageBody = $"New contact form submission:\n" +
                                      $"First Name: {FirstName}\n" +
                                      $"Last Name: {LastName}\n" +
                                      $"Email: {Email}\n" +
                                      $"Message: {Message}";

                //for sending the SMS message
                string accountSid = "ACa75b443b769428cb8ef92f848329367e";
                string authToken = "61dcdf27784ca2a43539187284c86f32";
                string twilioPhoneNumber = "+13156182675"; 

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: messageBody,
                    from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                    to: new Twilio.Types.PhoneNumber("+31 6 86116079")
                );

                return RedirectToPage("/Hotel/SuccessContactPage");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

                if (ex.InnerException != null)
                {
                    ErrorMessage += " Inner Exception: " + ex.InnerException.Message;
                }

                return Page();
            }
        }


        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    try
        //    {
        //        // Compose the email message
        //        string subject = "Contact Us Form Submission";
        //        string body = $"First Name: {FirstName}\n" +
        //                      $"Last Name: {LastName}\n" +
        //                      $"Email: {Email}\n" +
        //                      $"Message: {Message}";

        //        // Send the email
        //        using (MailMessage mailMessage = new MailMessage())
        //        {
        //            mailMessage.From = new MailAddress("himalaryal707@gmail.com");
        //            mailMessage.To.Add("himalaryal707@gmail.com"); 
        //            mailMessage.Subject = subject;
        //            mailMessage.Body = body;

        //            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
        //            {
        //                smtpClient.EnableSsl = true;
        //                smtpClient.UseDefaultCredentials = false;
        //                smtpClient.Credentials = new NetworkCredential("himalaryal707@gmail.com", "HelloWorld@7"); 

        //                smtpClient.Send(mailMessage);
        //            }
        //        }

        //        return RedirectToPage("SuccessPage");
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorMessage = ex.Message;

        //        if (ex.InnerException != null)
        //        {
        //            ErrorMessage += " Inner Exception: " + ex.InnerException.Message;
        //        }

        //        return Page();


        //    }

        //}


    }

}
