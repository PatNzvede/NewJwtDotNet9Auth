using Microsoft.EntityFrameworkCore;
using NewJwtDotNet9Auth.Entities;

namespace NewJwtDotNet9Auth.Data
{
    public class UserDbContext(DbContextOptions <UserDbContext> options) : DbContext(options)
    {
        public DbSet<User>  Users { get; set; }
    }
}
