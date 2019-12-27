using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Nipuna.Model;

namespace Nipuna.DataAccess
{
    public class UserTypeDataAccess
    {
        public static IEnumerable<UserRole> getAllUserRoles()
        {
            using (var db = new NipunaDataContext())
            {
                var record = db.UserRoles.ToList();
                return record;
            }
        }
    }
}
