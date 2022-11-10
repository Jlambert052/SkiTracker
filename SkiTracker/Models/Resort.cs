namespace SkiTracker.Models {
    public class Resort {

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Lifts { get; set; }

        public int Vertical { get; set; }

        public int Trails { get; set; }

        public int Beginner { get; set; }

        public int Intermediate { get; set; }

        public int Expert { get; set; }

        public bool NightSki { get; set; }

        public bool Snowmaking { get; set; }


    }
}
