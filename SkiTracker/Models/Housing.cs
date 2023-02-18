using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {

    public class Housing {

        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Lodging { get; set; } = "";

        [Column(TypeName = "Decimal(7,2)")]
        public decimal LodgingCostPerNight { get; set; } = 1;

        [Column(TypeName = "Decimal(7,2)")]
        public decimal LodgingTotal { get; set; } = 1;

        public string Address { get; set; } = "";

        public int GuestMax { get; set; } = 1;

        public int Beds { get; set; } = 1;

        public decimal Bathrooms { get; set; } = 1;

        public bool SkiOut { get; set; } = false;

        public int MilesToMountain { get; set; }

        public bool Parking { get; set; } = true;

        

        [Required]
        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

    }
}
