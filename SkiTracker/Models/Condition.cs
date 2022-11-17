using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiTracker.Models {
    public class Condition {

        [Key]
        public int id { get; set; }

        [Column(TypeName = "Date")]
        public DateOnly Date { get; set; }

        [Column(TypeName ="Decimal(5,2)")]
        public decimal TemperatureF { get; set; }

        [StringLength(75)]
        public string Weather { get; set; }

        [StringLength(75)]
        public string SnowCondition { get; set; }


        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

    }
}
