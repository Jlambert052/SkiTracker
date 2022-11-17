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

        [Column(TypeName ="Decimal(7,0)")]
        public int Lifts { get; set; }

        [Column(TypeName ="Decimal(7,2)")]
        public int Vertical { get; set; }

        [Column(TypeName ="Decimal(7,0)")]
        public int Trails { get; set; }

        public bool BeginnerFriendly { get; set; }

        public bool IntermediateFriendly { get; set; }

        public bool ExpertFriendly { get; set; }

        public bool NightSki { get; set; }

        public bool Snowmaking { get; set; }


    }
}
