using Microsoft.EntityFrameworkCore;
using HomeRecipewebproject.Models;
namespace HomeRecipewebproject.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options) 
        {

        }
        public DbSet<Add> Adding  { get; set; }


    }
}
