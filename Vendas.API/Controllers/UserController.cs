using Microsoft.AspNetCore.Mvc;

using Vendas.API.Interface;
using Vendas.API.Model;

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
	[ProducesResponseType(typeof(ResponseUserRegister), StatusCodes.Status201Created)]
	public async Task<ActionResult> RegisterUser([FromServices] IUserRepository register, [FromBody] RequesteRegisterUser user)
	{
		var model = await register.AddUser(user);
		return Created(string.Empty, model);
	}

	[HttpGet]
	[ProducesResponseType(typeof(List<RegisterUsers>), StatusCodes.Status200OK)]
	public async Task<ActionResult<List<RegisterUsers>>> GetUsers([FromServices] IUserRepository user)
	{
		var result = await user.GetUsers();
		return result;
	}
}
