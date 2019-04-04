using ENTITIES;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer<DatabaseContext>(new MyInitializer());
        }
        public DbSet<User> Users { get; set; }

        public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                context.Users.Add(
                    new User()
                    {
                        Name = "Ali Yasin",
                        SurName = "DOĞAN",
                        Email = "a.yasindogan@gmail.com",
                        Password = "12345"
                    });

                context.Users.Add(
                    new User()
                    {
                        Name = "Yasin",
                        SurName = "DOĞAN",
                        Email = "yasin@gmail.com",
                        Password = "12345"
                    });
                context.Users.Add(
                    new User()
                    {
                        Name = "Ali ",
                        SurName = "DOĞAN",
                        Email = "ali@gmail.com",
                        Password = "12345"
                    });
                context.Users.Add(
                  new User()
                  {
                      Name = "Mustafa ",
                      SurName = "DOĞAN",
                      Email = "mustafa@gmail.com",
                      Password = "12345"
                  });
                context.Users.Add(
                    new User()
                    {
                        Name = "Abdulvahhab",
                        SurName = "DOĞAN",
                        Email = "abdulvahhab@gmail.com",
                        Password = "12345"
                    });
                context.SaveChanges();
            }
        }
    }
}
