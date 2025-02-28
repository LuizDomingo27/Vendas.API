using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Vendas.API.Model;

namespace Vendas.API.Map;

public class EmployesMap : IEntityTypeConfiguration<Employes>
{
	public void Configure(EntityTypeBuilder<Employes> builder)
	{
		//Criando a configuração para a nossa tabela no Banco de dados
		builder.ToTable("Employes");
		builder.Property(p => p.Nome).HasMaxLength(150).IsRequired();
		builder.Property(p => p.EstadoCivil).IsRequired();
		builder.Property(p => p.Escolaridade).IsRequired();
		builder.Property(p => p.Genero).IsRequired();
		builder.Property(p => p.Idade).IsRequired();
		builder.Property(p => p.Status).IsRequired();
		builder.Property(p => p.Cargo).IsRequired();
		builder.Property(p => p.Setor).IsRequired();
		builder.Property(p => p.Salario).HasPrecision(10, 2).IsRequired();
		builder.Property(p => p.Cidade).IsRequired();
		builder.Property(p => p.Estado).IsRequired();
	}
}