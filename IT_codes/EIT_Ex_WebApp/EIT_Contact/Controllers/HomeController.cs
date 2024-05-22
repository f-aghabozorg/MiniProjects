using Ex_7_BL = Ex_7_ContactProjectBL;
using Ex_7_DA = Ex_7_ContactProjectDA;
using Ex_8_BL = Ex_8_ContactProjectBL;
using Ex_8_DA = Ex_8_ContactProjectDA;
using Ex_9_BL = Ex_9_ContactProjectBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Ex_9_ContactProjectDBFirst;

namespace EIT_Contact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //exercise 5
            Ex_7_BL.AdminBL adminBl = new Ex_7_BL.AdminBL();
            Ex_7_BL.UserBL userBL = new Ex_7_BL.UserBL();
            Ex_7_DA.Admin admin = adminBl.Insert("Ex_7_Sadegh", "Amini", false, "", "sadegh@gmail.com", "tehran", "Ex_7_09397441125");
            Ex_7_DA.User user = userBL.Insert("Ex_7_Ali", "Alavi", false, "", "Ex_7_090184563256", admin.Id, 0);
            var string_Contains = user.Numbers[0].PhoneNumber.Contains("0938");
            bool b = string_Contains != null ? string_Contains : false;

            //excercise 6
            List<Ex_7_DA.User> users = userBL.GetUserWithPhone("0938");
            List<UserDtoObject> userList1 = userBL.GetWithName("Ali");
            Ex_7_DA.User user1 = userBL.GetWithId(1);
            var userList = userBL.GetWithName("a");

            userBL.Update(user.Id, "Ex_7_taghy");

            //exercise 8
            Ex_8_BL.AdminBL adminBl2 = new Ex_8_BL.AdminBL();
            Ex_8_BL.UserBL userBL2 = new Ex_8_BL.UserBL();
            Ex_8_BL.NumberBL numberBL = new Ex_8_BL.NumberBL();
            Ex_8_DA.Admin admin2 = adminBl2.Insert("Ex_8_Amirali", "rahmani", false, "", "amir@gmail.com", "tehran", "Ex_8_091211121047");
            Ex_8_DA.User user2 = userBL2.Insert("Ex_8_Atefe", "Moghimi", false, "", "Ex_8_0901001213", admin2.Id, 0);
            bool b2 = user2.Numbers.First().PhoneNumber.Contains("0912");

            List<Ex_8_DA.User> users2 = userBL2.GetUserWithPhone("0901");
            List<UserDtoObjectt> userList_2 = userBL2.GetWithName("Ex_8_Atefe");
            Ex_8_DA.User user12 = userBL2.GetWithId(user2.Id);
            List<UserDtoObjectt> userList2 = userBL2.GetWithName("a");
            Ex_8_DA.Number number = numberBL.GetItemWithId(user2.Numbers.First().Id);

            userBL2.Update(user2.Id, "Ex_8_Morad");

            //excercise 9
            bool IsExceptionHandling = false;
            if (IsExceptionHandling)
                try
                {
                    int[] arrayint = new int[2];
                    arrayint[4] = 2;
                    Admins Admin = null;
                    Admin.Address = "";
                    int y = 2;
                    int x = y / 0;

                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new Exception("خارج از محدوده موردنظر انتخاب شده");
                }
                catch (NullReferenceException ex)
                {
                    throw new Exception("نمیتوان از null  انتخابی کرد");
                }
                catch (DivideByZeroException ex)
                {
                    throw new Exception("تقسیم بر صفر");
                }
                catch (Exception ex)
                {
                    throw new Exception("خطای ناشناخته");
                }

            Ex_9_BL.AdminBL adminBl3 = new Ex_9_BL.AdminBL();
            Ex_9_BL.UserBL userBL3 = new Ex_9_BL.UserBL();
            Ex_9_BL.NumberBL numberBL3 = new Ex_9_BL.NumberBL();
            Admins admin3 = adminBl3.Insert("Ex_9_Mohsen", "MirAlizade", false, "", "Mohsen@gmail.com", "tehran", "Ex_9_091211121047");
            Users user3 = userBL3.Insert("Ex_9_Atefe", "Moghimi", false, "", "Ex_9_0901001213", admin3.Id, 0);
            bool b3 = user3.Numbers.First().PhoneNumber.Contains("0912");

            List<Users> users3 = userBL3.GetUserWithPhone("0901");
            List<UserDtoObjecttt> userList_3 = userBL3.GetWithName("Ex_9_Atefe");
            Users user13 = userBL3.GetWithId(user3.Id);
            List<UserDtoObjecttt> userList3 = userBL3.GetWithName("a");
            Numbers number3 = numberBL3.GetItemWithId(user3.Numbers.First().Id);

            List<UserDtoObjecttt> userList31 = userBL3.GetWithNameWithADO("ali");

            userBL3.Update(user3.Id, "Ex_9_Sobhan");


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}