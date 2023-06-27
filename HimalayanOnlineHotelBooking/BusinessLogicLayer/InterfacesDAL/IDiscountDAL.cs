using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IDiscountDAL
    {
        bool InsertDiscount(Discount discount);
        bool UpdateDiscount(Discount discount, string discountId);
        bool DeleteDiscount(int discountId);
        DataTable GetAllDiscountInfo();
        int GetDiscountRate(string discountid);
        List<string> GetDiscountNames();
    }
}
