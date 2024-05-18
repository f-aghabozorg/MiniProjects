using Ex_7_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_ContactProjectBL
{
    public class NumberBL
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

        public Number Insert(string phoneNumber, byte type, int userId)
        {

            int Id = GetAllAsQueryable().Any()?GetAllAsQueryable().Max(p => p.Id) + 1:1;
            Number number = new Number();
            number.PhoneNumber = phoneNumber;
            number.Type = type;
            number.UserId = userId;
            number.Id = Id;
            Context.Numbers.Add(number);
            Context.SaveChanges();
            return number;
        }

        public List<Number> Insert(List<Number> Numbers)
        {
            foreach (Number number in Numbers)
            {
                Context.Numbers.Add(number);
                Context.SaveChanges();
            }
            return Numbers;
        }

        public IQueryable<Number> GetAllAsQueryable()
        {
            return (from p in Context.Numbers
                    select p);
        }
    }
}
