using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MShop.Model.Models
{
    [Table("Visitors")]
    public class Visitor
    {
        [Key]
        public Guid ID { set; get; }
        public DateTime VisitedDate { set; get; }
        [Required]
        [MaxLength(250)]
        public string IPAddress { set; get; }
    }
}
