using Microsoft.AspNetCore.Mvc;

using Vendas.API.Interface;
using Vendas.API.Model;

namespace Vendas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	#region GetAll Users
	[HttpGet]
	[ProducesResponseType(typeof(List<RegisterUsers>), StatusCodes.Status200OK)]
	public async Task<ActionResult<List<RegisterUsers>>> GetUsers([FromServices] IUserRepository user)
	{
		List<RegisterUsers> result = await user.GetUsers();
		return result;
	}
	#endregion

	#region Login User

	[HttpPost("login")]
	[ProducesResponseType(typeof(ResponseUserRegister), StatusCodes.Status200OK)]
	public async Task<ActionResult<bool>> LoginUser([FromServices] IUserRepository Iuser, [FromBody] LoginUser user)
	{
		bool userLogd = await Iuser.Login(user);
		return userLogd;
	}

	#endregion

	#region Register User
	[HttpPost]
	[ProducesResponseType(typeof(ResponseUserRegister), StatusCodes.Status201Created)]
	public async Task<ActionResult> RegisterUser([FromServices] IUserRepository register, [FromBody] RequesteRegisterUser user)
	{
		ResponseUserRegister model = await register.AddUser(user);
		return Created(string.Empty, model);
	}

	#endregion
}
