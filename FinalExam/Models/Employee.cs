using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Table("Employee")] //Add the table to the top of each of the models, import the using statement for red squiggle
    public class Employee
    {

        [Key] //Add data annotations
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? UserID { get; set; } // add the question mark to the foreign key, this means it can be NULL for the Foreign key
        public virtual User User { get; set; } //Navigational Properties
    }
}