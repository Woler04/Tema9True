﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tema9.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}