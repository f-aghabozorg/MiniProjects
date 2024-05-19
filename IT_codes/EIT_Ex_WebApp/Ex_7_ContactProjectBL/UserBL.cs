using Ex_7_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_ContactProjectBL
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

        private NumberBL _numberBL;

        public NumberBL _NumberBL
        {
            get
            {
                if (_numberBL == null)
                    _numberBL = new NumberBL();
                return _numberBL;
            }
            set { _numberBL = value; }
        }

        #endregion 
        #region Manipulate
        public User Insert(string firstName, string lastName, bool Gender, string PicturePath, string Number, int AdminId, byte type)
        {
            int userId = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
            int NumberId = _NumberBL.GetAllAsQueryable().Any() ? _NumberBL.GetAllAsQueryable().Max(p => p.Id) : 1;

            List<Number> Numbers = new List<Number>();
            Numbers.Add(new Number()
            {
                PhoneNumber = Number,
                Type = type,
                Id = NumberId,
                UserId = userId

            });

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
            user.FirstName = name;
            Context.SaveChanges();
            return true;
        }
        #endregion

        #region GetMethod
        public User GetWithId(int userId)
        {
            return Context.Users.Where(p => p.Id == userId).FirstOrDefault();
        }
        public List<UserDtoObject> GetWithName(string name)
        {
            return Context.Users
                   .Where(user => user.FirstName.Contains(name))
                   .Select(user => new UserDtoObject
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