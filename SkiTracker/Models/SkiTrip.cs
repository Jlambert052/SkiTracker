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
        public DateOnly Arrival { get; set; } = new DateOnly();

        [Column(TypeName = "Date")]
        public DateOnly Departure { get; set; } = new DateOnly();

        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "planning";

        public int Attendees { get; set; } = 1;

        [Column(TypeName = "Decimal(5,2)")]
        public decimal TicketTotal { get; set; } = 1;

        [StringLength(255)]
        public string Notes { get; set; } = "";
        [Range(1,5, ErrorMessage = "Grade the Resort on a whole number scale, 1 to 5")]
        public int Rating { get; set; } = 0;

        public int RunTotal { get; set; } = 0;

        public virtual IEnumerable<SkiTripAttendee>? Skiiers { get; set; }

        public virtual IEnumerable<SkiTripLine>? SkiTripLines { get; set; }

        public int HousingId { get; set; }
        public virtual Housing? Housing { get; set; }
    }
}
