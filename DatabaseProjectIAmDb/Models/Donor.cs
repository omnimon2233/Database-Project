﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectIAmDb.Models
{
    public class Donor
    {
        [Key]
        public int Donor_Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength =5)]
        public string Address { get; set; }

        [Required]
        [StringLength(30, MinimumLength =2)]
        public string City { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        [RegularExpression(@"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$", ErrorMessage = "Must have a dollar value of at least 1.00 and must be formatted the same way.")]
        public string Phone { get; set; }

        [DisplayName("Receipt Required")]
        [RegularExpression(@"^[0-1]{1}$", ErrorMessage = "Please Enter 'True' or 'False'")]
        public int Receipt_Required_Bool { get; set; }

        [DisplayName("Referred by")]
        [ForeignKey("Person")]
        public int Person_Id { get; set; }


    }
}
