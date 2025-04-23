using Vendas.API.DependencyInjection;

namespace Vendas.API;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		#region Serviços

		builder.Services.AddControllers();
		builder.Services.AddOpenApi();
		builder.Services.AddSwaggerGen();

		#endregion

		#region Adicionamos a injeção de dependência - configurando

		builder.Services.AddDependecyInjection(builder.Configuration);

		#endregion

		var app = builder.Build();

		#region Configure the HTTP request pipeline.

		if (app.Environment.IsDevelopment())
		{
			app.MapOpenApi();
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		#endregion

		app.UseHttpsRedirection();
		app.UseAuthorization();
		app.MapControllers();

		app.Run();
	}
}