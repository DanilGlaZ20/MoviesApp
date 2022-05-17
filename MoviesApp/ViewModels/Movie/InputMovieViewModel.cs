using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.ViewModels.Movie
{
    public class InputMovieViewModel
    {
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}