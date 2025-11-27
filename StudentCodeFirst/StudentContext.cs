using System.Data.Entity;

namespace StudentCodeFirst
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDBConnectionString") { }
        public DbSet<Student> Students { get; set; }
    }
}
