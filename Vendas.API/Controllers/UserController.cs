using Microsoft.AspNetCore.Mvc;

using Vendas.API.Model;
using Vendas.API.Repository;

namespace Vendas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	[HttpPost("login")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
	[ProducesDefaultResponseType]
	public async Task<ActionResult<LoginUser>> LoginUser([FromServices] IUserRepository iuser,
		[FromBody] LoginUser user)
	{
		var userLogd = await iuser.Login(user);
		return userLogd ? Ok("Usuário logado com sucesso") : BadRequest("Usuário ou senha inválidos");
	}

	[HttpPost("register")]
	public async Task<ActionResult<RegisterUsers>> RegisterUser([FromBody] RegisterUsers user,
		[FromServices] IUserRepository register)
	{
		var model = await register.AddUser(user);
		return model;
	}
}
