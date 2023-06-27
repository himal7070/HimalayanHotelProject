using DataAccessLayer.FakeDAL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;
namespace TestProject
{
    [TestClass]
    public class PaymentDALTests
    {
        private IPaymentDAL paymentDAL;

        [TestInitialize]
        public void Setup()
        {
            paymentDAL = new FakePaymentDAL();
        }

        [TestMethod]
        public void AddPayment_ValidPayment_ReturnsTrue()
        {
            Payment payment = new Payment
            {
                PaymentStatus = "Paid",
                PaymentType = "Credit Card",
                PaymentAmount = 100,
                BookingId = 1
            };

            bool result = paymentDAL.AddPayment(payment);

            Assert.IsTrue(result, "Failed to add payment.");
        }

        [TestMethod]
        public void GetAllPaymentInfo_NoPayments_ReturnsEmptyDataTable()
        {
            DataTable result = paymentDAL.GetAllPaymentInfo();

            Assert.IsNotNull(result, "Returned DataTable is null.");
            Assert.AreEqual(0, result.Rows.Count, "Returned DataTable should be empty.");
        }

        [TestMethod]
        public void GetAllPaymentInfo_WithPayments_ReturnsPopulatedDataTable()
        {
            Payment payment1 = new Payment
            {
                PaymentStatus = "Paid",
                PaymentType = "Credit Card",
                PaymentAmount = 100,
                BookingId = 1
            };

            Payment payment2 = new Payment
            {
                PaymentStatus = "Pending",
                PaymentType = "Cash",
                PaymentAmount = 50,
                BookingId = 2
            };

            paymentDAL.AddPayment(payment1);
            paymentDAL.AddPayment(payment2);

            DataTable result = paymentDAL.GetAllPaymentInfo();

            Assert.IsNotNull(result, "Returned DataTable is null.");
            Assert.AreEqual(2, result.Rows.Count, "Returned DataTable should contain 2 rows.");

            Assert.AreEqual("Paid", result.Rows[0]["PaymentStatus"], "Incorrect PaymentStatus in the first row.");
            Assert.AreEqual("Credit Card", result.Rows[0]["PaymentType"], "Incorrect PaymentType in the first row.");
            Assert.AreEqual(100.00m, result.Rows[0]["PaymentAmount"], "Incorrect PaymentAmount in the first row.");
            Assert.AreEqual(1, result.Rows[0]["BookingId"], "Incorrect BookingId in the first row.");

            Assert.AreEqual("Pending", result.Rows[1]["PaymentStatus"], "Incorrect PaymentStatus in the second row.");
            Assert.AreEqual("Cash", result.Rows[1]["PaymentType"], "Incorrect PaymentType in the second row.");
            Assert.AreEqual(50.00m, result.Rows[1]["PaymentAmount"], "Incorrect PaymentAmount in the second row.");
            Assert.AreEqual(2, result.Rows[1]["BookingId"], "Incorrect BookingId in the second row.");
        }
    }
}
