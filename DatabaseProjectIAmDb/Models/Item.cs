using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectIAmDb.Models
{
    public class Item
    {
        [Key]
        public int Item_id { get; set; }

        [Required]
        [StringLength(40, MinimumLength =2)]
        public String Name { get; set; }

        [DisplayName("Expected Sale Value")]
        [RegularExpression(@"^\d{1, 5}\.\d{2}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public double Expected_Sale_Value { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [RegularExpression(@"^\d{1, 3}\.\d{2}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public double Start_Price { get; set; }

        [RegularExpression(@"^\d{1, 3}\.\d{2}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public double End_Price { get; set; }

        [Required]
        [RegularExpression(@"^\d{1, 3}\.\d{2}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public double Min_Increment { get; set; }

        [RegularExpression(@"^\d{1, 5}\.\d{2}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public double Buyout_Price { get; set; }

        [Required]
        [ForeignKey("Donor")]
        public int Donor_Id { get; set; }

        [ForeignKey("Event")]
        public int Event_Id { get; set; }

        [DisplayName("Bidder Id")]
        [ForeignKey("Person")]
        public int Person_Id { get; set; }


    }
}
