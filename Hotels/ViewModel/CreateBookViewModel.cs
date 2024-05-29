
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotels.ViewModel
{
    [Keyless]
    public class CreateBookViewModel
    {
        public string CustomerName {get; set;}



        [MaxLength(14), MinLength(14)]
        public string NationalId { get; set;}
        
        [MaxLength(11), MinLength(11)]
        public string PhoneNumber { get; set; }
        public string BranchId {get; set;}
        public DateTime CheckIn {get; set;}
        public DateTime CheckOut { get; set; }

        public List<RoomViewModel> rooms { get; set; }

    }
}
