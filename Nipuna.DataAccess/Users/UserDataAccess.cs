using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nipuna.Model;

namespace Nipuna.DataAccess
{
    public class UserDataAccess
    {
        // get all users
        public static IEnumerable<User> getAllUsers()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Users.ToList();
                return record;
            }
        }

        // add new user
        public static bool addUser(User user)
        {
            using (var db = new NipunaDataContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }

        // update user account
        public static User updateUser(User user)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Users.SingleOrDefault(x => x.UserName == user.UserName);
                record.SurName = user.SurName;
                record.FirstName = user.FirstName;
                record.LastName = user.LastName;
                record.Nic = user.Nic;
                user.ContactNo = user.ContactNo;
                //user.Password = user.Password;
                user.Role = user.Role;

                db.SaveChanges();

                return record;
            }
        }

        // update user account password 
        public static bool UpdatePassword(User user) 
        {
            using (var db = new NipunaDataContext()) 
            {
                var record = db.Users.SingleOrDefault(x => x.UserName == user.UserName);
                record.Password = user.Password;
                db.SaveChanges();
                return true;
            }
        }

        // delete user account
        public static User deleteUser(User user)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Users.SingleOrDefault(x => x.UserName == user.UserName);
                record.IsRemoved = user.IsRemoved;
                db.SaveChanges();

                return record;
            }
        }

        // find user by user ID
        public static User findByUserId(User user)
        {
            using (var db = new NipunaDataContext())
            {
                var records = db.Users.SingleOrDefault(x => x.UserName == user.UserName);
                return records;
            }
        }

        // filter user datagrid
        public static IEnumerable<User> filterUsers(string search)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Users.Where(x => x.UserName.StartsWith(search)
                                            || x.SurName.StartsWith(search)
                                            ||x.FirstName.StartsWith(search)
                                            ||x.LastName.StartsWith(search)).ToList();
                return record;
            }
        }

        // Reset user passwords
        public static User resetUserPassword(User user)
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.Users.SingleOrDefault(x => x.UserName == user.UserName);
                record.Password = user.Password;
                db.SaveChanges();

                return record;
            }
        }
    }
}
