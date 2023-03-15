using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {

    public class Run {

        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string Name { get; set; } = "";

        [StringLength(50)]
        public string Difficulty { get; set; } = "";

        [StringLength(150)]
        public string Features { get; set; } = "";

        [StringLength(150)]
        public string Notes { get; set; } = "";

        [Column(TypeName = "Decimal(5,2)")]
        public decimal Vertical { get; set; } = 0;

        [Required]
        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

    }
}
