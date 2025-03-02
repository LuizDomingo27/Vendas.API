using Microsoft.EntityFrameworkCore;

using Vendas.API.DataContex;

namespace Vendas.API.Repository;

public static class DependecyInjection
{
	public static void AddDependecyInjection(this IServiceCollection services, IConfiguration config)
	{
		AddRepository(services);
		AddSqlServer(services, config);
	}

	public static void AddSqlServer(IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<EmployesContext>(option =>
			option.UseSqlServer(configuration.GetConnectionString("ConectSqlServer")));
	}

	public static void AddRepository(IServiceCollection services)
	{
		services.AddScoped<IEmployeRepository, EmployeRepository>();
	}
}
