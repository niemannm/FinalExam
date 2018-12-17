using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Table("Order")] //Add the table to the top of each of the models, import the using statement for red squiggle
    public class Order
    {
        [Key] //Add data annotations
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        public DateTime Date { get; set; }

        public int? CustomerID { get; set; } // add the question mark to the foreign key, this means it can be NULL for the Foreign key
        public virtual Customer Customer { get; set; } //Navigational Properties

        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}