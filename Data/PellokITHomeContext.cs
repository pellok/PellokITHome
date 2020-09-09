using Microsoft.EntityFrameworkCore;

namespace PellokITHome.Data
{
    public class PellokITHomeContext : DbContext
    {
        public PellokITHomeContext (
            DbContextOptions<PellokITHomeContext> options)
            : base(options)
        {
        }

        public DbSet<PellokITHome.Models.Article> Article { get; set; }
    }
}