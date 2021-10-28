using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Movies.Models
{
    public enum Genres
    {
        Comedy,
        Drama,
        Thriller,
        Action,
        Horror
    }
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; } = Genres.Action;

        [Range(5.99, 7.99), Required]
        public decimal Price { get; set; }
    }
}
