using EntekhabReshteBL;
using RecursiveFunction;
using System;
using System.Collections.Generic;
using System.Web.UI;
using Ex_11_2_DA = Ex_11_2_TPT_EntekhabReshteDA;
using Ex_11_2_BL = Ex_11_2_TPT_EntekhabReshteBL;
using Ex_12_1_BL = Ex_12_1_TPH_EntekhabReshteBL;
using Ex_12_1_DA = Ex_12_1_TPH_EntekhabReshteDA;
namespace EntekhabReshte
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //exercise recursive
            int Fibbonachi_Term = 10;
            List<int> Fibo_List = new List<int>();
            for (int i = 1; i <= Fibbonachi_Term; i++)
                Fibo_List.Add(Fibbonachi.Fibbonachi_Recursion(i));

            int Factorial_term = 5;
            int calc_Fact = Factorial.Factorial_Recursion(Factorial_term);

            //exercise 11
            UserBL userBL = new UserBL();
            userBL.Insert("fateme", "aghabozorg", "09104574854");

            //exercise 11-2 TPT
            Ex_11_2_BL.StudentBL studentBL = new Ex_11_2_BL.StudentBL();
            studentBL.Insert("fateme", "aghabozorg", "09104574854",200);

            //exercise 12-1 TPH
            Ex_12_1_BL.StudentBL studentBL2 = new Ex_12_1_BL.StudentBL();
            studentBL2.Insert("fateme", "aghabozorg", "09104574854", 200);
            Ex_12_1_BL.TeacherBL teacherBL = new Ex_12_1_BL.TeacherBL();
            teacherBL.Insert("fatemeT", "aghabozorgT", "09104574854", 200);
           // List<Ex_12_1_DA.Student> students = studentBL2.GetAll();

            Console.WriteLine(".");

        }
    }
}