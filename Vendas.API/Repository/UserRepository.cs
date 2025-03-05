using Microsoft.EntityFrameworkCore;

using Vendas.API.DataContex;
using Vendas.API.Model;

namespace Vendas.API.Repository;

public class UserRepository : IUserRepository
{
	private readonly EmployesContext _context;
	private readonly IEncryptyPassword _encryptyPassword;
	public UserRepository(EmployesContext context, IEncryptyPassword encrypty)
	{
		_encryptyPassword = encrypty;
		_context = context;
	}

	public async Task<RegisterUsers> AddUser(RegisterUsers user)
	{
		user.Password = _encryptyPassword.Encrypty(user.Password);
		user.ConfirmPassword = user.Password;
		await _context.AddAsync(user);
		_context.SaveChanges();
		return user;
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
