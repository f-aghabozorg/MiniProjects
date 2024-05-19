using Ex_8_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_8_ContactProjectBL;

namespace Ex_8_ContactProjectBL
{
    public class UserBL :BaseBL<User>

    {
        #region Manipulate
        public User Insert(string firstName, string lastName, bool Gender, string PicturePath, string Number, int AdminId, byte type)
        {
            List<Number> Numbers = new List<Number>();
            Numbers.Add(new Number()
            {
                PhoneNumber = Number,
                Type = type,

            });

            User user = new User();
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
            User user = base.GetItemWithId(userId);
            if (user == null) return false;
            user.FirstName = name;
            
            return base.Update();
        }
        #endregion

        #region GetMethod
        public User GetWithId(int userId)
        {
            return Context.Users.Where(p => p.Id == userId).FirstOrDefault();
        }
        public List<UserDtoObjectt> GetWithName(string name)
        {
            return Context.Users
                   .Where(user => user.FirstName.Contains(name))
                   .Select(user => new UserDtoObjectt
                   {
                       FirstName = user.FirstName,
                       LastName = user.LastName,
                       Numbers = user.Numbers.Select(p => p.PhoneNumber).ToList(),

                   })
                   .ToList();
        }

        public List<User> GetUserWithPhone(string PhoneNumber)
        {
            return Context.Users.Where(user => user.Numbers.Any(num => num.PhoneNumber.Contains(PhoneNumber))).ToList();
        }
       
        #endregion

    }
}
public class UserDtoObjectt
{
    public int Id;
    public string FirstName;
    public string LastName;
    public List<string> Numbers;
}