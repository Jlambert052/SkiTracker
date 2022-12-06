namespace SkiTracker.Models {
    public class SkiTripAttendee {

        public int Id { get; set; }

        public int SkiierId { get; set; }
        public virtual Skiier? Skiier {get; set;}

        public int SkiTripId { get; set; }
        public virtual SkiTrip? SkiTrip {get; set;}

    }
}
