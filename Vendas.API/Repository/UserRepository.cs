using Microsoft.EntityFrameworkCore;

using Vendas.API.DataContex;
using Vendas.API.Domain;
using Vendas.API.Interface;
using Vendas.API.Model;

namespace Vendas.API.Repository;

public class UserRepository : IUserRepository
{
	private readonly EmployesContext _context;
	private readonly IEncryptyPassword _encryptyPassword;
	private readonly IGeneratorToken _token;

	public UserRepository(EmployesContext context, IEncryptyPassword encrypty, IGeneratorToken token)
	{
		_encryptyPassword = encrypty;
		_context = context;
		_token = token;
	}

	public async Task<ResponseUserRegister> AddUser(RequesteRegisterUser request)
	{
		var user = new RegisterUsers
		{
			Email = request.Email!,
			Password = _encryptyPassword.Encrypty(request.Password!),
			ConfirmPassword = _encryptyPassword.Encrypty(request.ConfirmPassword!)
		};

		await _context.RegisterUsers.AddAsync(user);
		await _context.SaveChangesAsync();

		return new ResponseUserRegister
		{
			Email = user.Email,
			Token = _token.GenerateToken(user.UserIdentifier),
			UserIdentifier = user.UserIdentifier
		};
	}

	public async Task<List<RegisterUsers>> GetUsers()
	{
		return await _context.RegisterUsers.ToListAsync();
	}

	public async Task<bool> Login(LoginUser user)
	{
		List<RegisterUsers> use = await _context.RegisterUsers.ToListAsync();

		if (user.Email == use[0].Email && user.Password == use[1].Password)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
