﻿namespace Data.EntityTypeConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class CarExtraConfiguration : IEntityTypeConfiguration<CarExtra>
    {
        public void Configure(EntityTypeBuilder<CarExtra> builder)
        {
            builder.HasKey(tcm => new { tcm.CarId, tcm.ExtraId });

            builder.HasOne(tcm => tcm.Car)
                .WithMany(t => t.CarExtras)
                .HasForeignKey(tcm => tcm.CarId);

            builder.HasOne(tcm => tcm.Extra)
                .WithMany(tc => tc.CarExtras)
                .HasForeignKey(tcm => tcm.ExtraId);
        }
    }
}