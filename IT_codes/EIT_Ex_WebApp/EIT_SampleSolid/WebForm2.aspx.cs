using Ex_12_2_SampleSolidBL;
using Ex_12_2_SampleSolidDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace EIT_SampleSolid
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Exercise 12
            Cartooni cartoony = new Cartooni();
            Conservi conservy = new Conservi();
            Biskooiti biskooity = new Biskooiti();

            PackageBandi packageBandi = new PackageBandi(cartoony);
            packageBandi.Packaging();

            packageBandi = new PackageBandi(conservy);
            packageBandi.Packaging();

            packageBandi = new PackageBandi(biskooity);             //injection by consctructor
            packageBandi.Packaging();
            //packageBandi.type = "cartoony"                        //injection by property
            //packageBandi.Packaging(cartoony);                     //injection by method


            //Exercise 13
            UnityManager unityManager = new UnityManager();
            IPackaging cartoony1 = unityManager.Container.IsRegistered<IPackaging>("Cartooni") ? unityManager.Container.Resolve<IPackaging>("Cartooni") : null;
            IPackaging biskooity1 = unityManager.Container.Resolve<IPackaging>("Biskooiti");
            IPackaging conservy1 = unityManager.Container.Resolve<IPackaging>("Conservi");

            PackageBandi packageBandi1 = new PackageBandi(cartoony1);
            packageBandi1.Packaging();


            Console.WriteLine(".");

        }
    }
}