using Microsoft.EntityFrameworkCore;
using DoThiPhuong0473.Models;

namespace DoThiPhuong0473.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       
        public DbSet<DTPStudent> DTPStudents {get; set;}
       
    }    
        
}
