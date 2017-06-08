using System.Data.Entity;

namespace WebApplication1.Models {
    public class User {
        public int ID { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int NoOfMsg { get; set; } = 0;
        public bool canMessage { get; set; } = true;
    }

    public class UserDbContext : DbContext {
        public DbSet<User> Users { get; set; }
    }
}