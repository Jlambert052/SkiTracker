using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {
    public class SkiTripAttendee {

        public int Id { get; set; }

        [Column(TypeName ="Decimal(7,2)")]
        public decimal LodgingCost { get; set; } = 1;



        public int SkiierId { get; set; }
        public virtual Skiier? Skiier {get; set;}

        public int SkiTripId { get; set; }
        public virtual SkiTrip? SkiTrip {get; set;}

    }
}
