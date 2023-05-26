using Microsoft.EntityFrameworkCore;

namespace ExamMVC.Entities
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<SubjectExam> SubjectExam { get; set; }
    }
}
