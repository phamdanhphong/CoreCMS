using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("LanguageItems")]
    public class LanguageItem:DomainEntity<int>
    {
        public int LanguageNationalId { get; set; }
        public int LanguageKeyId { get; set; }
        [Column(TypeName = "ntext")]
        public string LanguageItemTitle { get; set; }
        public string LanguageItemDesc { get; set; }
        public string LanguageItemParams { get; set; }

        [ForeignKey("LanguageNationalId")]
        public virtual LanguageNational LanguageNationals { set; get; }

        [ForeignKey("LanguageKeyId")]
        public virtual LanguageKey LanguageKeys { set; get; }

    }
}
