using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        [Required(ErrorMessage = "Please enter a value")]
        public int missionQuestionID { get; set; }

        public int missionID { get; set; }

        public int userID { get; set; }

        [DisplayName("Question")]
        public String mqQuestion { get; set; }

        public String mqAnswer { get; set; }
    }
}