using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_15_UniversityCMN;
using Unity;

namespace Ex_15_UniversityBL
{
    public class UserBL : BaseBL<IUserDA, IUser>
    {
        public IUser GetItem(int id)
        {
            return UnityManager.Container.Resolve<IUserDA>().GetItem(id);
        }
        public override void Submit(IUser entity)
        {
            //entity.Id = 1;
            base.Submit(entity);
        }
    }
}
