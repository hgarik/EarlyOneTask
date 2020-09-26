using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Helpers.Models
{
    public class GiveScoreRequest
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Score { get; set; }
        public string Token { get; set; }
    }
}
