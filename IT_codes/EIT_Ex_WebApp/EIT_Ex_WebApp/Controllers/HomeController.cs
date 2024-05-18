using Ex_7_BL = Ex_7_ContactProjectBL;
using Ex_8_BL = Ex_8_ContactProjectBL;
using Ex_7_DA = Ex_7_ContactProjectDA;
using Ex_8_DA = Ex_8_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace EIT_Ex_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //exercise 5
            Ex_7_BL.AdminBL adminBl = new Ex_7_BL.AdminBL();
            Ex_7_BL.UserBL userBL = new Ex_7_BL.UserBL();
            Ex_7_DA.Admin admin = adminBl.Insert("Sadegh", "Amini", false, "", "sadegh@gmail.com", "tehran", "09397441125");
            Ex_7_DA.User user = userBL.Insert("Ali", "Alavi", false, "", "093884563256", admin.Id, 0);
            bool b = user.Numbers[0].PhoneNumber.Contains("0938");

            //excercise 6
            List<Ex_7_DA.User> users = userBL.GetUserWithPhone("0938");
            List<UserDtoObject> userList1 = userBL.GetWithName("Ali");
            Ex_7_DA.User user1 = userBL.GetWithId(1);
            var userList =userBL.GetWithName("a");
            
            userBL.Update(2, "taghy");

            //exercise 8
            Ex_8_BL.AdminBL adminBl2 = new Ex_8_BL.AdminBL();
            Ex_8_BL.UserBL userBL2 = new Ex_8_BL.UserBL();
            Ex_8_DA.Admin admin2 = adminBl2.Insert("Amirali", "rahmani", false, "", "amir@gmail.com", "tehran", "091211121047");
            Ex_8_DA.User user2 = userBL2.Insert("Atefe", "Moghimi", false, "", "0901001213", admin.Id, 0);
            bool b2= user2.Numbers.First().PhoneNumber.Contains("0912");

            List<Ex_8_DA.User> users2 = userBL2.GetUserWithPhone("0901");
            List<UserDtoObjectt> userList_2 = userBL2.GetWithName("Atefe");
            Ex_8_DA.User user12 = userBL2.GetWithId(user2.Id);
            var userList2 = userBL2.GetWithName("a");

            userBL2.Update(2, "Morad");


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}