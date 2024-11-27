using Lab14.Models;

namespace Lab14.Requests
{
    public class CreateStudentsForGradeRequest
    {
        public IEnumerable<Student> Students { get; set; }
    }
}
