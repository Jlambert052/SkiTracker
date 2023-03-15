
using System.Text.Json.Serialization;

namespace SkiTracker.Models {
    public class SkiTripLine {
        public int Id { get; set; }

        public int RunCount { get; set; } = 0;

        public int RunId { get; set; }
        public virtual Run? Run { get; set; }

        public int SkiTripId { get; set; }
        [JsonIgnore]
        public virtual SkiTrip? SkiTrip { get; set; }

        public int SkiierId { get; set; }
        public virtual Skiier? Skiier { get; set; }

    }
}
