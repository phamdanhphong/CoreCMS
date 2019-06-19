using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Enums;

namespace CoreCMS.Application.ViewModels.Item
{
    public class GroupViewModel
    {
        public int Id { get; set; }

        public int GroupId
        {
            get
            {
                return Id;
            }
            set { GroupId = value; }
        }
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string GroupName
        {
            get
            {
                return Name;
            }
            set { GroupName = value; }
        }
        [Required]
        public int LanguageId { set; get; }
        [StringLength(50)]
        public string GroupApp { get; set; }
        public int Level { set; get; }
        public int? ParentId { get; set; }
        [StringLength(255)]
        public string ParentsId { get; set; }
        [StringLength(1000)]
        public string GroupDescription { get; set; }
        public string GroupContent { get; set; }
        [StringLength(1000)]
        public string GroupImage { get; set; }
        public string GroupSeoPageTitle { set; get; }
        public string GroupSeoAlias { set; get; }
        public string GroupSeoKeywords { set; get; }
        public string GroupSeoDescription { set; get; }
        public int GroupSortOrder { set; get; }
        public DateTime GroupDateCreated { set; get; }
        public DateTime GroupDateModified { set; get; }
        public string GroupParams1 { get; set; }
        public string GroupParams2 { get; set; }
        public string GroupParams3 { get; set; }
        public string GroupParams4 { get; set; }
        public string GroupParams5 { get; set; }

        public int GroupIparams1 { get; set; }
        public int GroupIparams2 { get; set; }
        public int GroupIparams3 { get; set; }
        public int GroupIparams4 { get; set; }
        public int GroupIparams5 { get; set; }

        public Status GroupStatus { set; get; }
        public ICollection<ItemViewModel> Items { set; get; }
    }
}
