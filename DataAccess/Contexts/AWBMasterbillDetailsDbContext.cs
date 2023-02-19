using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    /// <summary>
    /// AWBMasterbillDetails database context used for migration setup
    /// </summary>
    public class AWBMasterbillDetailsDbContext : DbContext
    {
        /// <summary>
        /// Ctor for AWBMasterbillDetailsDbContext
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public AWBMasterbillDetailsDbContext(DbContextOptions<AWBMasterbillDetailsDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        /// <summary>
        /// The database set of AWBMasterbillDetails
        /// </summary>
        public DbSet<AWBMasterbillDetailsModel> AWBMasterbillDetails { get; set; }
    }
}
