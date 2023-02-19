using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookHooked.Web.Data
{
    public class UserBook
    {
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Range(0,2)]
        public int Status { get; set; }
    }
}
