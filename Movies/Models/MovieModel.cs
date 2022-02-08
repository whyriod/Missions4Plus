using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieModel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage="Please enter a valid movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a valid movie year.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter a valid movie Director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a valid movie rating.")]
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Build foreign key relationship.
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
