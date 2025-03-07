using Microsoft.EntityFrameworkCore;

using Vendas.API.Criptographia;
using Vendas.API.DataContex;
using Vendas.API.Domain;
using Vendas.API.Infra;
using Vendas.API.Interface;
using Vendas.API.Repository;

namespace Vendas.API.DependencyInjection;

public static class DependecyInjection
{
	public static void AddDependecyInjection(this IServiceCollection services, IConfiguration config)
	{
		AddJwtTokens(services, config);
		AddRepository(services);
		AddSqlServer(services, config);
		AddUserLogin(services);
		AddEncryptyPassword(services);
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

	public static void AddJwtTokens(IServiceCollection services, IConfiguration config)
	{
		var expirtationTimeOrDate = config.GetValue<uint>("Settings:Jwt:ExpirationTime");
		var secretKey = config.GetValue<string>("Settings:Jwt:SigningKey");
		services.AddScoped<IGeneratorToken>
			(
				option => new JwtTokenGenerator(expirtationTimeOrDate, secretKey)
			);
	}

	public static void AddUserLogin(IServiceCollection services)
	{
		services.AddScoped<IUserRepository, UserRepository>();
	}

	public static void AddEncryptyPassword(IServiceCollection services)
	{
		services.AddScoped<IEncryptyPassword, EncryptyPasword>();
	}
}
