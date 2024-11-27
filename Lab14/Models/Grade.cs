namespace Lab14.Models
{
    public class Grade
    {
        public int IdGrade { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
