using System.Data.Entity;

namespace RestierTests.Models
{
    public class Context : DbContext
    {
        public Context() : base(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=RestierTest;Integrated Security = True; MultipleActiveResultSets=True")
        {
        }

        public Context(string connection) : base(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=RestierTest;Integrated Security = True; MultipleActiveResultSets=True")
        {
        }

        public virtual DbSet<Person> People { get; set; }
    }
}