namespace SkiTracker.Models {
    public class Condition {

        public int id { get; set; }

        public DateOnly Date { get; set; }

        public decimal Temperature { get; set; }

        public string Weather { get; set; }

        public string SnowCon { get; set; }

        public int ResortId { get; set; }


    }
}
