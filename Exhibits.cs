using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dinosaur_Exhibit.Data
{
    public class Exhibits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EID { get; set; }

        [Display(Name = "Exhibit Name")]
        public string EName { get; set; }

        [Display(Name = "Exhibit Location")]
        public string Elocation { get; set; }

        [ForeignKey("DID")]
        public Dinosaurs DID { get; set; }
    }
}
