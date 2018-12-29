using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Interfaces;
using CoreCMS.Infrastructure.SharedKernel;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace CoreCMS.Data.Entities
{
    [Table("Settings")]
    public class Setting:DomainEntity<string>,IMultiLanguage<int>
    {
        [StringLength(1500)]
        public string Description { get; set; }
        public string Content { get; set; }

        [Required]
        public int LanguageId { get; set; }
    }
}
