using System.ComponentModel.DataAnnotations;

namespace Tema9.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Book?> Books { get; set; }
        public virtual ICollection<Genre?> Genres { get; set; }
    }
}
