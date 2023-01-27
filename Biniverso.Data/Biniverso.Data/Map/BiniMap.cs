using Biniverso.Business.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biniverso.Data.Map
{
    public class BiniMap : BaseMap<Bini>
    {
        public BiniMap() : base("tb_bini") { }

        public override void Configure(EntityTypeBuilder<Bini> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Path).HasColumnName("titulo").HasColumnType("varchar(250)").IsRequired();
            builder.Property(x => x.Title).HasColumnName("titulo").HasColumnType("varchar(250)").IsRequired();
            builder.Property(x => x.Description).HasColumnName("descricao").HasColumnType("varchar(500)").IsRequired();
            builder.Property(x => x.Date).HasColumnName("data_cadastro").IsRequired();
        }
    }
}
