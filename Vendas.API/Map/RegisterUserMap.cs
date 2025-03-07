using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Vendas.API.Model;

namespace Vendas.API.Map;

public class RegisterUserMap : IEntityTypeConfiguration<RegisterUsers>
{
	public void Configure(EntityTypeBuilder<RegisterUsers> builder)
	{
		builder.ToTable("RegisterUsers");
		builder.HasKey(p => p.Id);
		builder.Property(p => p.UserIdentifier).IsRequired();
		builder.Property(p => p.Email).HasMaxLength(150).IsRequired();
		builder.Property(p => p.Password).HasMaxLength(2000).IsRequired();
	}
}
