namespace EFCoreExample
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Navigation Property: Eine Liste von Studenten
        public List<Student> Students { get; set; } = new();
    }
}