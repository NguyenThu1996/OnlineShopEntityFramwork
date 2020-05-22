using ShopOline.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOline.Dao
{
    public class UserDao
    {
        OnlineShopDbContext db = null;
        public UserDao()
        {
            db = new OnlineShopDbContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName, string password)
        {
            var result = db.Users.Count(x => x.UserName == userName && x.PasssWord == password);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}