using CoreCMS.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Interfaces;
using CoreCMS.Data.Enums;

namespace CoreCMS.Data.Entities
{
    [Table("Groups")]
    public class Group : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISoftable, IDateTracking, IMultiLanguage<int>
    {

       

       

        [StringLength(500)]
        public string Name { get; set; }
        [Required]
        public int LanguageId { set; get; }
        [StringLength(50)]
        public string App { get; set; }
        public int? Level { set; get; }
        public int? ParentId { get; set; }
        [StringLength(255)]
        public string ParentsId { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(1000)]
        public string Image { get; set; }


        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public int SortOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string Params1 { get; set; }
        public string Params2 { get; set; }
        public string Params3 { get; set; }
        public string Params4 { get; set; }
        public string Params5 { get; set; }

        public int? Iparams1 { get; set; }
        public int? Iparams2 { get; set; }
        public int? Iparams3 { get; set; }
        public int? Iparams4 { get; set; }
        public int? Iparams5 { get; set; }

        public Status Status { set; get; }
        public virtual ICollection<Item> Items { set; get; }
    }
}