using EntekhabReshteBL;
using RecursiveFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            int calc_Fact = Factorial.Factorial_Recursion(5);

            //excercise 11
            //UserBL userBL = new UserBL();
            //StudentBL studentBL = new StudentBL();
            //userBL.Insert("fateme", "aghabozorg", "09104574854");



        }
    }
}