using Microsoft.EntityFrameworkCore;

using Vendas.API.Map;
using Vendas.API.Model;

namespace Vendas.API.DataContex;

public class EmployesContext : DbContext
{
	//Criamos o construtor
	public EmployesContext(DbContextOptions<EmployesContext> options) : base(options)
	{
	}

	//Criamos o nosso DbSet<>
	public DbSet<Employes> Employes { get; set; }

	//Sobrescrevemos o metodo OmodelCreating()
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//Aqui estou afirmando para não ter chave primaria
		modelBuilder.Entity<Employes>(e => e.HasNoKey());
		
		//Para criar as tabelas em nosso banco de dados precisamos adicionar o mapeamento
		modelBuilder.ApplyConfiguration(new EmployesMap());

		//Criando as configurações
		base.OnModelCreating(modelBuilder);
	}
}