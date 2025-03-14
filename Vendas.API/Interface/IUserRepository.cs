using Vendas.API.Model;

namespace Vendas.API.Interface;

public interface IUserRepository
{
	public Task<ResponseUserRegister> AddUser(RequesteRegisterUser user);
	public Task<bool> Login(LoginUser user);
	public Task<List<RegisterUsers>> GetUsers();

}
