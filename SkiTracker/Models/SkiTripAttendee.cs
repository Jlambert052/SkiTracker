﻿using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {
    public class SkiTripAttendee {

        public int Id { get; set; }

        [Column(TypeName ="Decimal(7,2)")]
        public decimal LodgingCost { get; set; } = 1;

        [Column(TypeName = "Decimal(7,2)")]
        public decimal PaidAmount { get; set; } = 0;

        public bool LodgePaid { get; set; } = false;

        public int RunCountTotal { get; set; } = 0;

        [Required]
        public int SkiierId { get; set; }
        public virtual Skiier? Skiier {get; set;}

        [Required]
        public int SkiTripId { get; set; }
        public virtual SkiTrip? SkiTrip {get; set;}

    }
}
