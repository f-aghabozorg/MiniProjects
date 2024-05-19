using Ex_9_ContactProjectDBFirst;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_ContactProjectBL
{
    public class UserBL : BaseBL<Users>
    {
        #region Manipulate
        public Users Insert(string firstName, string lastName, bool Gender, string PicturePath, string Number, int AdminId, byte type)
        {
            List<Numbers> Numbers = new List<Numbers>();
            Numbers.Add(new Numbers()
            {
                PhoneNumber = Number,
                Type = type,

            });

            Users user = new Users();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Gender = Gender;
            user.PicturePath = PicturePath;
            user.AdminId = AdminId;
            user.Numbers = Numbers;

            return base.Insert(user);
        }
        public bool Update(int userId, string name)
        {
            Users user = base.GetItemWithId(userId);
            if (user == null) return false;
            user.FirstName = name;

            return base.Update();
        }
        #endregion

        #region GetMethod
        public Users GetWithId(int userId)
        {
            return Context.Users.Where(p => p.Id == userId).FirstOrDefault();
        }
        public List<UserDtoObjecttt> GetWithName(string name)
        {
            return Context.Users
                   .Where(user => user.FirstName.Contains(name))
                   .Select(user => new UserDtoObjecttt
                   {
                       FirstName = user.FirstName,
                       LastName = user.LastName,
                       Numbers = user.Numbers.Select(p => p.PhoneNumber).ToList(),

                   })
                   .ToList();
        }
        public List<UserDtoObjecttt> GetWithNameWithADO(string name)
        {
            string query = "select * from Admins";
            if (!string.IsNullOrEmpty(name))
                query += $" Where FirstName like N'%{name}%'";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@name", name);


            DataTable dt = ExcecuteADO(query, dic);

            List<UserDtoObjecttt> UserDtoObject = new List<UserDtoObjecttt>();
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                    UserDtoObject.Add(new UserDtoObjecttt
                    {
                        FirstName = dr["FirstName"].ToString(),
                        LastName = dr["LastName"].ToString(),
                    });
            return UserDtoObject;

        }
        public List<Users> GetUserWithPhone(string PhoneNumber)
        {
            return Context.Users.Where(user => user.Numbers.Any(num => num.PhoneNumber.Contains(PhoneNumber))).ToList();
        }

        #endregion

    }
}
public class UserDtoObjecttt
{
    public int Id;
    public string FirstName;
    public string LastName;
    public List<string> Numbers;
}