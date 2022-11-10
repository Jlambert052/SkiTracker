namespace SkiTracker.Models {
    public class SkiTrip {

        public int Id { get; set; }

        public string Trip { get; set; }

        public DateOnly Arrival { get; set; }

        public DateOnly Departure { get; set; }

        public int ResortId { get; set; }

        public int SkiierId { get; set; }

        public string Notes { get; set; } = "";

        public int Rating { get; set; }

    }
}
