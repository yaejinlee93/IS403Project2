using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required(ErrorMessage = "Please enter a value")]
        public int userID { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter a value")]
        public String userEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter a value")]
        [DataType(DataType.Password)]
        public String userPassword { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter a value")]
        public String userFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter a value")]
        public String userLastName { get; set; }
    }
}