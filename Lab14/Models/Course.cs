﻿namespace Lab14.Models
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
