using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Table("User")] //Add the table to the top of each of the models, import the using statement for red squiggle
    public class User
    {
        [Key] //Add data annotations
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string UserRole { get; set; }
    }
}