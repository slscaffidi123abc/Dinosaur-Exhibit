using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dinosaur_Exhibit.Data
{
    public class Dinosaurs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }


        [Display(Name = "Dinosaur Name")]
        public string DName { get; set; }


        [Display(Name ="Dinosaur Name")]
        public int DWeight { get; set; }

      

        [ForeignKey("DID")]
        public  Exhibits EID { get; set; }





    }
}
