namespace BookHooked.Web.Data
{
    public class Book
    {
        public Book()
        {
            this.UserBooks = new HashSet<UserBook>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
