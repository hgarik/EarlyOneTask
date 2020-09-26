using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Models
{
    public class AccountSession
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public Account Account { get; set; }
        public int? AccountId { get; set; }

    }
}
