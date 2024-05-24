using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_15_2_DtoUniversityCMN;
using Unity;

namespace Ex_15_2_DtoUniversityBL
{
    public class UserBL : BaseBL<IUserDA, IUser> ,IUserBL
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
