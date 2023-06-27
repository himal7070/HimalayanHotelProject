using System.ComponentModel.DataAnnotations;

namespace DataTransferClasses.Classes
{
    public class Guest
    {
        private int guestId;
        private string? firstName;
        private string? lastName;
        private string? email;
        private string? phone;
        private string? passportNumber;
        private string? city;
        private string? street;
        private string? postalCode;
        private string? country;
     

        [Required]
        public int GuestId
        {
            get => guestId;
            set => guestId = value;
        }

        [Required]
        [StringLength(50)]
        public string? FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        [Required]
        [StringLength(50)]
        public string? LastName
        {
            get => lastName;
            set => lastName = value;
        }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email
        {
            get => email;
            set => email = value;
        }

        [Phone]
        public string? Phone
        {
            get => phone;
            set => phone = value;
        }

        [Required]
        [StringLength(20)]
        public string? PassportNumber
        {
            get => passportNumber;
            set => passportNumber = value;
        }

        [Required]
        [StringLength(50)]
        public string? City
        {
            get => city;
            set => city = value;
        }
        [Required]
        [StringLength(50)]
        public string? Street
        {
            get => street;
            set => street = value;
        }

        [Required]
        [StringLength(10)]
        public string? PostalCode
        {
            get => postalCode;
            set => postalCode = value;

        }

        [Required]
        [StringLength(50)]
        public string? Country
        {
            get => country;
            set => country = value;

        }



    }
}
