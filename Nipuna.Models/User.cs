using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nic { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsRemoved { get; set; }

        public User()
        {
            IsRemoved = false;
        }
    }
}
