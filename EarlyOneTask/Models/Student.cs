using System.Collections.Generic;

namespace EarlyOneTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<StudentScore> Scores { get; set; }
    }
}