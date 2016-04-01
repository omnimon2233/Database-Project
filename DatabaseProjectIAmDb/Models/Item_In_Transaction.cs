using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectIAmDb.Models
{
    public class Item_In_Transaction
    {
        [Key]
        [Column(Order = 1)]
       // [ForeignKey("Transaction")]
        public virtual int Transaction_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        //[ForeignKey("Item")]
        public virtual int Item_Id { get; set; }
    }
}
