using System.ComponentModel.DataAnnotations;

namespace Tema9.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}