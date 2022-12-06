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

        [StringLength(100)]
        public string Status { get; set; } = "planning";

        public int Attendees { get; set; } = 0;

        [StringLength(200)]
        public string Housing { get; set; } = "";

        [Column(TypeName = "Decimal(7,2)")]
        public decimal HousingCost { get; set; } = 0;

        [StringLength(255)]
        public string Notes { get; set; } = "";

        public int Rating { get; set; } = 0;

        public int RunTotal { get; set; }

        [Column(TypeName ="Decimal(7,2)")]
        public decimal VerticalTotal { get; set; }

        public virtual IEnumerable<SkiTripAttendee>? Skiiers { get; set; }

        public virtual IEnumerable<SkiTripLine>? SkiTripLines { get; set; }
    }
}
