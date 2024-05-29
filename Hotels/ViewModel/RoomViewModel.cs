using Hotels.Constants;
using System.ComponentModel.DataAnnotations;

namespace Hotels.ViewModel
{
    public class RoomViewModel
    {
        public string? Id { get; set; }


        [EnumDataType(typeof(RoomTypes))]
        public string RoomType { get; set; }

        // [MinLength(1)]
        public int AdultsNumber { get; set; }

        /*[MinLength(0)]*/
        public int ChildrenNumber { get; set; }
    }
}
