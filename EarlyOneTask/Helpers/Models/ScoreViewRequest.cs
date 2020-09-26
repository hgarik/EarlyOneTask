using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Helpers.Models
{
    public class ScoreViewRequest
    {
        public int AccountId { get; set; }
        public int SubjectId { get; set; }
        public string Token { get; set; }

    }
}
