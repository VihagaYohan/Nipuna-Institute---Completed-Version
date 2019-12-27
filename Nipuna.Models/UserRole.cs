using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class UserRole
    {
        // properties
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsRemoved { get; set; }

        public UserRole()
        {
            IsRemoved = false;
        }
    }
}
