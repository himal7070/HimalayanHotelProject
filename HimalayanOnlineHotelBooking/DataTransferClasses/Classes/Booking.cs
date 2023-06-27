using System.ComponentModel.DataAnnotations;

namespace DataTransferClasses.Classes
{
    public class Booking
    {
        private int bookingId;
        private DateTime bookingDate;
        private int stayDuration;      
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private double bookingAmount;
        private int employeeId;
        private int guestId;
      
        private string? status;

        public int BookingId 
        { 
            get => bookingId;
            set => bookingId = value; 
        }


        [Required(ErrorMessage = "Booking date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate 
        { 
            get => bookingDate; 
            set => bookingDate = value; 
        }


        [Required(ErrorMessage = "Stay duration is required.")]
        [Display(Name = "Stay Duration")]
        public int StayDuration 
        { 
            get => stayDuration;
            set => stayDuration = value;
        }


        [Required(ErrorMessage = "Check-in date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-in Date")]
        public DateTime CheckInDate 
        { 
            get => checkInDate; 
            set => checkInDate = value; 
        }

        [Required(ErrorMessage = "Check-out date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-out Date")]
        public DateTime CheckOutDate 
        { 
            get => checkOutDate; 
            set => checkOutDate = value;
        }


        [Required(ErrorMessage = "Booking amount is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Booking amount must be a non-negative value.")]
        [Display(Name = "Booking Amount")]
        public double BookingAmount
        {
            get => bookingAmount;
            set => bookingAmount = value;
        }
        public int EmployeeId
        {
            get => employeeId;
            set => employeeId = value;
        }
        public int GuestId
        {
            get => guestId;
            set => guestId = value;
        }
     

        public string? Status 
        { 
            get => status;
            set => status = value; 
        }
    }
}
