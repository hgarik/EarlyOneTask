using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Helpers.Models
{
    public class Roles
    {
        public static byte Principal
        {
            get
            {
                return 1;
            }
        }
        public static byte Teacher
        {
            get
            {
                return 2;
            }
        }
        public static byte Student
        {
            get
            {
                return 3;
            }
        }
    }
}
