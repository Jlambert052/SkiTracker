using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SkiTracker.Models {
    [Index("Name", IsUnique = true, Name = "NameIndex")]
    [Index("Email", IsUnique = true, Name = "EmailIndex")]
    public class Skiier {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(75)]
        public string Email { get; set; }

        [StringLength(75)]
        public string Password { get; set; }

        [StringLength(25)]
        public string SnowSport { get; set; }

        [StringLength(50)]
        public string? Experience { get; set; }

        public virtual IEnumerable<SkiTrip>? Trips { get; set; }

    }
}
