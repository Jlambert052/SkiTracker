using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {

    public class Resort {

        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string Name { get; set; }

        [StringLength(75)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [Column(TypeName = "Decimal(5,2)")]
        public decimal TicketCostAvg { get; set; } = 1;

        public int PassCost { get; set; } = 1;

        [Column(TypeName = "Decimal(5,2)")]
        public decimal YearlySnowfall { get; set; } = 1;

        [StringLength(25)]
        public string OpenTime { get; set; } = "8 am";

        [StringLength(25)]
        public string CloseTime { get; set; } = "7 pm";

        public int Lifts { get; set; }

        public int Vertical { get; set; }

        public int Trails { get; set; }

        public bool BeginnerFriendly { get; set; }

        public bool ExpertsOnly { get; set; }

        public bool NightSki { get; set; }

        public bool Snowmaking { get; set; }


    }
}
