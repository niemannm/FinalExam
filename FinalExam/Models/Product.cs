using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Table("Product")] //Add the table to the top of each of the models, import the using statement for red squiggle
    public class Product
    {
        [Key] //Add data annotations
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}