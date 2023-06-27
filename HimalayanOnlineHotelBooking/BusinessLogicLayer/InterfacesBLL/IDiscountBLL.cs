using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IDiscountBLL
    {
        bool InsertDiscount(Discount discount);
        bool UpdateDiscount(Discount discount, string discountId);
        bool DeleteDiscount(int discountId);
        DataTable GetAllDiscountInfo();
        int GetDiscountRate(string discountId);
        List<string> GetDiscountNames();
    }
}
