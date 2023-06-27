using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferClasses.Classes
{
    public class Discount
    {
        private int discountId;

        private string discountName;

        private string discountDescription;

        private float discountRate;

        private DateTime startDate;

        private DateTime endDate;




        public int DiscountId
        {
            get => discountId;
            set => discountId = value;
        }
        public string Name
        {
            get => discountName;
            set => discountName = value;
        }
        public string Description
        {
            get => discountDescription;
            set => discountDescription = value;
        }

        public float Rate
        {
            get => discountRate;
            set => discountRate = value;
        }

        public DateTime StartDate
        {
            get => startDate;
            set => startDate = value;
        }

        public DateTime EndDate
        {
            get => endDate;
            set => endDate = value;
        }
    }
}
