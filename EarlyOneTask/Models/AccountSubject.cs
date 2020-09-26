using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Models
{
    public class AccountSubject
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SubjectId { get; set; }
    }
}
