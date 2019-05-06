using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oliver_ACT2019_Product.Web.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Region_Id { get; set; }

        [ForeignKey(nameof(Region_Id))]
        public Region Region { get; set; }
    }
}
