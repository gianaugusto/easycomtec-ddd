using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.BancoDeTalentos.Models;

namespace Infra.Data.BancoDeTalentos
{
    public class TalentoMap : IEntityTypeConfiguration<Talento>
    {
        public void Configure(EntityTypeBuilder<Talento> builder)
        {
            builder.ToTable("Talento");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.Skype).HasColumnName("Skype");
            builder.Property(x => x.Telefone).HasColumnName("Telefone");
            builder.Property(x => x.LinkedIn).HasColumnName("LinkedIn");
            builder.Property(x => x.Cidade).HasColumnName("Cidade");
            builder.Property(x => x.Estado).HasColumnName("Estado");
            builder.Property(x => x.Portfolio).HasColumnName("Portfolio");
            builder.Property(x => x.Pretensao).HasColumnName("Pretensao");
            builder.Property(x => x.InformacaoBancaria).HasColumnName("InformacaoBancaria");
            builder.Property(x => x.LinkCrud).HasColumnName("LinkCrud");
            builder.Property(x => x.OutroConhecimento).HasColumnName("OutroConhecimento");
            
        }
    }
}
