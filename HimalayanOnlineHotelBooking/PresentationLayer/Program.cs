using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using PresentationLayer.Views;
using BusinessLogicLayer.InterfacesDAL;
using DataAccessLayer.DAL;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            IUserDAL userDAL = new UserDAL();
            IUserBLL userBLL = new UserBLL(userDAL);
            Application.Run(new Login(userBLL));
            //Application.Run(new Homepage());

            //Application.Run(new Homepage());
        }
    }
}