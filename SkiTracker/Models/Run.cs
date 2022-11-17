using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SkiTracker.Models {

    public class Run {

        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Difficulty { get; set; }

        [StringLength(150)]
        public string Features { get; set; }

        [StringLength(150)]
        public string Notes { get; set; }

        public int ResortId { get; set; }
        public virtual Resort? Resort { get; set; }

    }
}
