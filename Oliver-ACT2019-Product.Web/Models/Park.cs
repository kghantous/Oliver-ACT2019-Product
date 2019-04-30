using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oliver_ACT2019_Product.Web.Models
{
    [Table("Park")]
    public class Park
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="Varchar(50)")]
        public string Name { get; set; }
        public int State_Id { get; set; }
    }
}
