using Vendas.API.Model;

namespace Vendas.API.Repository;

public interface IUserRepository
{
	Task<RegisterUsers> AddUser(RegisterUsers user);

	public Task<bool> Login(LoginUser user);
	
}
