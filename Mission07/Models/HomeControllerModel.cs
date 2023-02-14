using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission07.Models
{
    public class HomeControllerModel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        // MAX LENGTH of NOTES IS 25
        [MaxLength(25)]
        public string notes { get; set; }
    }
}
