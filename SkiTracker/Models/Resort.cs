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

        [StringLength(2, ErrorMessage = "{0} limit is {1} characters, use State Code")]
        public string State { get; set; }

        [Column(TypeName = "Decimal(5,2)")]
        public decimal TicketCostAvg { get; set; } = 1;

        public int PassCost { get; set; } = 1;

        public bool Ikon { get; set; } = false;

        public bool Epic { get; set; } = false;

        [Column(TypeName = "Decimal(5,2)")]
        public decimal YearlySnowfall { get; set; } = 1;

        [StringLength(25)]
        public string OpenTime { get; set; } = "8 am";

        [StringLength(25)]
        public string CloseTime { get; set; } = "7 pm";

        [StringLength(100)]
        public string Airports { get; set; } = "";

        public int Acreage { get; set; }

        public int Lifts { get; set; } = 1;

        public int Vertical { get; set; } = 0;

        public int Trails { get; set; } = 0;

        public bool? BeginnerFriendly { get; set; } = true;

        public bool? ExpertsFriendly { get; set; } = true;

        public bool? NightSki { get; set; } = true; 

        public bool? Snowmaking { get; set; } = true;

        public bool? MountainTransportation { get; set; } = true;

        [StringLength(255, ErrorMessage = "{0} limit is {1} characters.")]
        public string Notes { get; set; } = "";
    }
}
