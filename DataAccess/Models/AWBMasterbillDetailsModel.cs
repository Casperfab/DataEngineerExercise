using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class AWBMasterbillDetailsModel
    {
        [Key]
        public int Shipping_No { get; set; }
        public int TrackingNumber { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public DateTime EstimatedDeparture { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public int Index { get; set; }
    }
}
