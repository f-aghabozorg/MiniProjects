using Ex_15_BL = Ex_15_UniversityBL;
using Ex_15_CMN = Ex_15_UniversityCMN;
using Ex_15_DA = Ex_15_UniversityDA;

using Ex_15_2_BL = Ex_15_2_DtoUniversityBL;
using Ex_15_2_CMN = Ex_15_2_DtoUniversityCMN;
using Ex_15_2_DA = Ex_15_2_DtoUniversityDA;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace EIT_University
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Exercise 15-16
            Console.WriteLine(".");
            Ex_15_DA.User user = new Ex_15_DA.User()
            {
                FirstName = "Ex_15_Ali"
                ,
                LastName = "Ex_15_Alavi"
                ,
                MobileNumber = "09381449712"

            };

            Ex_15_DA.Teacher teacher = new Ex_15_DA.Teacher()
            {
                FirstName = "Ex_15_Minoo"
                ,
                LastName = "Ex_15_Molavi"
                ,
                MobileNumber = "09151447316"
                ,
                MadrakType = 1
                ,
                TeacherCode = 1

            };

            Ex_15_DA.Student student = new Ex_15_DA.Student()
            {
                FirstName = "Ex_15_Sobhan"
               ,
                LastName = "Ex_15_Karimi"
               ,
                MobileNumber = "09106247852"
                ,
                StudentCode = 1
            };

            Ex_15_BL.IUserDA UsersDA = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.IUserDA>();
            Ex_15_BL.ITeacherDA TeachersDA = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.ITeacherDA>();
            Ex_15_BL.IStudentDA StudentsDA = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.IStudentDA>();

            UsersDA.Insert(user);
            TeachersDA.Insert(teacher);
            StudentsDA.Insert(student);

            Ex_15_BL.IUserBL UsersBL = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.IUserBL>();
            Ex_15_BL.ITeacherBL TeachersBL = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.ITeacherBL>();
            Ex_15_BL.IStudentBL StudentsBL = Ex_15_CMN.UnityManager.Container.Resolve<Ex_15_BL.IStudentBL>();

            UsersBL.Insert(user);
            TeachersBL.Insert(teacher);
            StudentsBL.Insert(student);

            Console.WriteLine(".");

            //Exercise 15-16 //using DTOs
            Ex_15_2_BL.IUserDA UsersDA1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.IUserDA>();
            Ex_15_2_BL.ITeacherDA TeachersDA1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.ITeacherDA>();
            Ex_15_2_BL.IStudentDA StudentsDA1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.IStudentDA>();

            //UsersDA1.Insert(userDto);
            //TeachersDA1.Insert(teacherDto);
            //StudentsDA1.Insert(studentDto);

            Ex_15_2_BL.IUserBL UsersBL1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.IUserBL>();
            Ex_15_2_BL.ITeacherBL TeachersBL1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.ITeacherBL>();
            Ex_15_2_BL.IStudentBL StudentsBL1 = Ex_15_2_CMN.UnityManager.Container.Resolve<Ex_15_2_BL.IStudentBL>();

            //UsersBL1.Insert(userDto);
            //TeachersBL1.Insert(teacherDto);
            //StudentsBL1.Insert(studentDto);
            Console.WriteLine(".");

        }
    }
}