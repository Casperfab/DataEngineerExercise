using DataAccess.Models;

namespace DataAccess.Interfaces
{
    public interface IAWBMasterbillDetailsRepository
    {
        Task<AWBMasterbillDetailsModel> Get(int shippingNo);
    }
}
