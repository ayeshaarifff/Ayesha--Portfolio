using Cofee_Cafe.Models;
using Microsoft.EntityFrameworkCore;
namespace Cofee_Cafe.Controllers.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
    }

}
