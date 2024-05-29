using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotels.Models
{
    public class Book
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string CustomerId  { get; set; }
        public virtual Customer Customer { get; set; }

        public string BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual List<Room> Rooms { get; set; }
         
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        [DefaultValue(0)]
        public int discount { get; set; }

        [Column(TypeName = "money"), DefaultValue(0.0)]
        public decimal TotalCost { get; set; }
        
    }
}