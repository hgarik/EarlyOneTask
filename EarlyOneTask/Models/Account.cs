using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }

    }
}
