using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreCMS.Infrastructure.SharedKernel;

namespace CoreCMS.Data.Entities
{
    [Table("Logs")]
    public class Log : DomainEntity<int>
    {
        public DateTime CreateDate { get; set; }
        [StringLength(300)]
        public string  Url { get; set; }
        [StringLength(300)]
        public string Ip { get; set; }
        [StringLength(300)]
        public string Info { get; set; }
        [StringLength(300)]
        public string Author { get; set; }
        [StringLength(300)]
        public string Type { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
       
    }
}
