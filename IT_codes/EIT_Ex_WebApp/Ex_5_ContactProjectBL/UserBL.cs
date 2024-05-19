using Ex_5_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_ContactProjectBL
{
    public class UserBL

    {
        #region Property
        private ContactContext context;

        public ContactContext Context
        {
            get
            {
                if (context == null)
                    context = new ContactContext();
                return context;
            }
            set { context = value; }
        }
        #endregion 
        #region Manipulate
        public User Insert(string firstName, string lastName, bool Gender, string PicturePath, string Number, int AdminId, byte type)
        {

            List<Number> Numbers = new List<Number>();
            Numbers.Add(new Number()

            {
                PhoneNumber = Number,
                Type = type,
                Id = getAllAsQueryable().Max(p => p.Id) + 1,
                UserId = getAllAsQueryable().Max(p => p.Id) + 1

            });

            NumberBL numberBL = new NumberBL();

            List<Number> number_list = new List<Number>();
            number_list = numberBL.Insert(Numbers);

            int userId = getAllAsQueryable().Max(p => p.Id) + 1;

            User user = new User();
            user.Id = userId;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Gender = Gender;
            user.PicturePath = PicturePath;
            user.AdminId = AdminId;
            user.Numbers = Numbers;

            Context.Users.Add(user);
            Context.SaveChanges();


            return Context.Users.Single(p => p.Id == userId);

        }
        public bool Update(int userId, string name)
        {
            User user = GetWithId(userId);
            if (user == null) return false;
            Context.Users.Remove(user);
            user.FirstName = name;
            Context.Users.Add(user);
            Context.SaveChanges();
            return true;
        }
        #endregion

        #region GetMethod
        public User GetWithId(int userId)
        {
            return Context.Users.Where(p => p.Id == userId).FirstOrDefault();
        }
        public List<object> GetWithName(string name)
        {
            return Context.Users
                   .Where(user => user.FirstName.Contains(name) && user.LastName.Contains(name))
                   .Select(user => new UserDtoObject
                   {
                       FirstName = user.FirstName,
                       LastName = user.LastName,
                       Numbers = user.Numbers.Select(p => p.PhoneNumber).ToList(),

                   })
                   .OrderBy(p => p.Numbers)
                   .ToList<object>();
        }
        private IQueryable<User> getAllAsQueryable()
        {
            return (from p in Context.Users
                    select p);
        }
        #endregion

    }
}
public class UserDtoObject
{
    public int Id;
    public string FirstName;
    public string LastName;
    public List<string> Numbers;
}