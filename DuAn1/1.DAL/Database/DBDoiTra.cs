using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1.DAL.Database
{
    internal class DBDoiTra : IEntityTypeConfiguration<BangDoiTra>
    {
        public void Configure(EntityTypeBuilder<BangDoiTra> builder)
        {
            builder.ToTable("DoiTra");
            builder.HasKey(a => a.Id);
            builder.Property(p => p.IdHoaDon).IsRequired();
            
            builder.HasOne(x => x.HoaDon).WithMany().HasForeignKey(p => p.IdHoaDon);
            
            builder.Property(p => p.MaDoi).HasColumnName("MaDoi").HasColumnType("nvarchar(20)").IsRequired();
        }
    }
}
