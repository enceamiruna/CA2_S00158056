using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CA2_S00158056.Models
{
    public class Movie
    {
        [Key]
        public int movieID { get; set; }
        [Required]
        [DisplayName("Movie Title")]
        public string movieName { get; set; }
        [DisplayName("Movie Poster")]
        public string imageUrl { get; set; }
        [Required]
        [DisplayName("Movie Description")]
        public string description { get; set; }
        [DisplayName("Cast")]
        public virtual List<ScreenName> screenName { get; set; }
        //public List<KeyValuePair<Actor, string>> actors { get; set; }
    }
    public class Actor
    {
        [Key]
        public int actorID { get; set; }
        [Required]
        [DisplayName("Actor Name")]
        public string actorName { get; set; }
        [Required]
        [DisplayName("Actor Description")]
        public string description { get; set; }
        [DisplayName("Cast")]
        public virtual List<ScreenName> screenName { get; set; }
        //public List<KeyValuePair<Movie, string>> movies { get; set; }
    }
    public class ScreenName
    {
        [Key]
        [Column(Order = 0)]
        public int movieID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int actorID { get; set; }
        [DisplayName("Cast Name")]
        public string screenName { get; set; }
        [DisplayName("Actor")]
        public virtual Actor actor { get; set; }
        [DisplayName("Movie")]
        public virtual Movie movie { get; set; }
    }

    public class CA2Entities : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ScreenName> ScreenNames { get; set; }
        public CA2Entities() : base("CA2Entities") { }
    }
}