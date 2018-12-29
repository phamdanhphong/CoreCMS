using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("LanguageNationals")]
    public class LanguageNational : DomainEntity<int>
    {
        [StringLength(255)]
        public string LanguageNationalName { get; set; }
        [StringLength(255)]
        public string LanguageNationalFlag { get; set; }
        [StringLength(255)]
        public string LanguageNationalDesc { get; set; }
        public int LanguageNationalEnable { get; set; }
     
    }
}
