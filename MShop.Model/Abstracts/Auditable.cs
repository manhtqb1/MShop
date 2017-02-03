using System;
using System.ComponentModel.DataAnnotations;

namespace MShop.Model.Abstracts
{
    public abstract class Auditable : IAuditable
    {
        
        public DateTime? CreatedDate { set; get; }
        [MaxLength(250)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(250)]
        public string UpdatedBy { set; get; }

        [MaxLength(250)]
        public string MetaKeyword { set; get; }
        [MaxLength(250)]
        public string MetaDecription { set; get; }

        public bool Status { set; get; }
    }
}