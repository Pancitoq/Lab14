namespace Lab14.Requests
{
    public class EnrollRequest
    {
        public int StudentId { get; set; }
        public IEnumerable<int> CourseIds { get; set; }
    }
}
