using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project2.Models
{
    [Table("Missions")]
    public class Missions
    {
        //MISSIONS INFO
        [Key]
        [Required(ErrorMessage = "Please enter a value")]
        public int missionID { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionName { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionPresName { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionAddress { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionLanguage { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionClimate { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionMainReligion { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public String missionImage { get; set; }
    }
}