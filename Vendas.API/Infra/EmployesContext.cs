using Microsoft.EntityFrameworkCore;

using Vendas.API.Map;
using Vendas.API.Model;

namespace Vendas.API.Infra;

public class EmployesContext : DbContext
{
	//Criamos o construtor
	public EmployesContext(DbContextOptions<EmployesContext> options) : base(options) { }

	//Criamos o nosso DbSet<>
	public DbSet<Employes> Employes { get; set; }
	public DbSet<RegisterUsers> RegisterUsers { get; set; }

	//Sobrescrevemos o metodo OnModelCreating()
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//Aqui estou afirmando para não ter chave primaria
		modelBuilder.Entity<Employes>(e => e.HasNoKey());
		modelBuilder.Entity<RegisterUsers>(e => e.HasNoKey());

		//Para criar as tabelas em nosso banco de dados precisamos adicionar o mapeamento
		modelBuilder.ApplyConfiguration(new EmployesMap());
		modelBuilder.ApplyConfiguration(new RegisterUserMap());

		//Criando as configurações
		base.OnModelCreating(modelBuilder);
	}
}