namespace Lab14.Models
{
    public class Enrollment
    {
        public int IdEnrollment { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
    }
}
