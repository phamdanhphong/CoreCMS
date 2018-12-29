using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Enums;
using CoreCMS.Data.Interfaces;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Items")]
  public  class Item:DomainEntity<int>,ISwichtable,IDateTracking,IHasSeoMetaData,ISoftable,IMultiLanguage<int>
    {
        [StringLength(255)]
        public string  Name { get; set; }

        [Required]
        public int GroupId { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [StringLength(255)]
        public string Key { get; set; }
        [StringLength(255)]
        public string App { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(1000)]
        public string Image { get; set; }

        [StringLength(1000)]
        public string Url { get; set; }

        [StringLength(1000)]
        public string Author { get; set; }

        [Required]
        [DefaultValue(0)]
        public int TotalView { get; set; }


        [Required]
        [DefaultValue(0)]
        public decimal Price { set; get; }

        [Required]
        [DefaultValue(0)]
        public decimal SalesPrice { set; get; }




        [ForeignKey("GroupId")]
        public  virtual  Group Group { set; get; }

       
     
        public string SeoPageTitle { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Params1 { get; set; }
        public string Params2 { get; set; }
        public string Params3 { get; set; }
        public string Params4 { get; set; }
        public string Params5 { get; set; }
        public int SortOrder { get; set; }

        public Status Status { get; set; }
        
    }
}
