using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Table("Order_Detail")] //Add the table to the top of each of the models, import the using statement for red squiggle
    public class Order_Detail
    {

        [Key, Column(Order = 1)] //Add data annotations (the '1' is what column this key is found in the databse)
        
        public int? OrderID { get; set; } //add question mark

        [Key, Column(Order = 2)] //Add data annotations (the '2' is what column this key is found in the database
        public int? ProductID { get; set; }

        public int QuantityOrdered { get; set; }

        public int QuotedPrice { get; set; }
    }
}