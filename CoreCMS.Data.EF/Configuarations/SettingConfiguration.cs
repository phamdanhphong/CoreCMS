using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Data.EF.Extensions;
using CoreCMS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCMS.Data.EF.Configuarations
{
    public class SettingConfiguration : DbEntityConfiguration<Setting>
    {
        public override void Configure(EntityTypeBuilder<Setting> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(200)
                .IsRequired().HasColumnType("nvarchar(200)");
        }
    }
}
