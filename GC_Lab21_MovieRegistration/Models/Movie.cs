using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GC_Lab21_MovieRegistration.Models
{
    //CREATING AN ENUM AS A CLASS PROPERTY:
    //https://stackoverflow.com/questions/22335103/c-sharp-how-to-use-get-set-and-use-enums-in-a-class

    public enum Genre { Horror, Action, Western, Gangster, Romance, Noir, Comedy, Musical, ScienceFiction, Thriller}

    public class Movie
    {
        [Key]
        [Required(ErrorMessage="Please enter a movie ID number.")]
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter a movie title.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage ="Movie title must be between 1 and 50 characters in length.")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage="Please enter a release date.")]
        [Range(1888, 2020, ErrorMessage = "Year must be between 1888 and 2020.")]
        public int Year { get; set; }
        public string Cast { get; set; }
        public string Director { get; set; }
        public double RentalCost { get; set; }
        public int Runtime { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string title, Genre genre, int year, string cast, string director, double rentalCost, int runtime)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
            Cast = cast;
            Director = director;
            RentalCost = rentalCost;
            Runtime = runtime;
        }

    }
}
