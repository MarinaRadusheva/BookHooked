using Microsoft.AspNetCore.Identity;

namespace BookHooked.Web.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.UserBooks = new HashSet<UserBook>();
        }
        public byte[]? Img { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
