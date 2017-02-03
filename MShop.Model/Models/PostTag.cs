using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
    }
}