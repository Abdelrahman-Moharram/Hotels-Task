using Hotels.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Hotels.ViewModel
{
    public class BooksListViewModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public List<RoomViewModel> Rooms { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        
        public int discount { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCost { get; set; }

    }
}
