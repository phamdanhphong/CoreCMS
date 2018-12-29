using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("LanguageKeys")]
    public class LanguageKey:DomainEntity<int>
    {
        [StringLength(1000)]
        public string LanguageKeyTitle { get; set; }
        [StringLength(1000)]
        public string LanguageKeyDesc { get; set; }
    }
}
