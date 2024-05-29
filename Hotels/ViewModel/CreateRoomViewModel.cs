using System.ComponentModel.DataAnnotations;

namespace Hotels.ViewModel
{
    public class CreateRoomViewModel
    {
        public string RoomType { get; set; }

        [MinLength(1)]
        public int AdultsNumber { get; set; }

        [MinLength(0)]
        public int ChildrenNumber { get; set; }
    }
}
