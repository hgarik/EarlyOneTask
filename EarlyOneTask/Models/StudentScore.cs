namespace EarlyOneTask.Models
{
    public class StudentScore
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public int ProvidedById { get; set; }


    }
}