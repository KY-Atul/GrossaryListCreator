using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GrossaryListCreator.Model
{
    public class List
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Required]
        public decimal Quantity { get; set; }

    }
}
