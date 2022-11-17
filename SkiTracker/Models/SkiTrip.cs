using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {
    public class SkiTrip {

        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required]
        public string TripName { get; set; } = "";

        [Column(TypeName = "Date")]
        public DateOnly Arrival { get; set; }

        [Column(TypeName = "Date")]
        public DateOnly Departure { get; set; }

        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

        public int SkiierId { get; set; }
        public virtual Skiier? Skiier { get; set; }

        [StringLength(255)]
        public string Notes { get; set; } = "";

        [Required]
        public int Rating { get; set; } = 0;

        public virtual IEnumerable<SkiTripLine>? SkiTripLines { get; set; }
    }
}
