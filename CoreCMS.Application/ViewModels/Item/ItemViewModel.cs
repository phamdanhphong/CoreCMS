using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Enums;

namespace CoreCMS.Application.ViewModels.Item
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
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
        public GroupViewModel Group { set; get; }
        public string SeoPageTitle { get; set; }
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
