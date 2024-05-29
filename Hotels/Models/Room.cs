using Hotels.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hotels.Models
{
    public class Room
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey(nameof(BookId))]
        public string BookId { get; set; }
        public virtual Book Book { get; set; }

        [EnumDataType(typeof(RoomTypes))]
        public string RoomType { get; set; }

        [MinLength(1)]
        public int AdultsNumber { get; set; }

        [MinLength(0)]
        public int ChildrenNumber { get; set; }
    }
}
