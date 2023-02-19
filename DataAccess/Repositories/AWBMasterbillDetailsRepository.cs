using DataAccess.Contexts;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories
{
    /// <summary>
    /// AWBMasterbillDetailsRepository class
    /// </summary>
    public class AWBMasterbillDetailsRepository : IAWBMasterbillDetailsRepository
    {
        private readonly AWBMasterbillDetailsDbContext _dbContext;

        /// <summary>
        /// Ctor for AWBMasterbillDetailsRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public AWBMasterbillDetailsRepository(AWBMasterbillDetailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Gets the database instance of the shipping number
        /// </summary>
        /// <param name="shippingNo"></param>
        /// <returns></returns>
        public async Task<AWBMasterbillDetailsModel> Get(int shippingNo)
        {
            return await Task.FromResult(_dbContext.AWBMasterbillDetails.Where(x => x.Shipping_No.Equals(shippingNo)).FirstOrDefault()).ConfigureAwait(false);
        }
    }

}
