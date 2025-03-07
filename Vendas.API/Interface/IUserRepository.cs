using Vendas.API.Model;

namespace Vendas.API.Interface;

public interface IUserRepository
{
	Task<ResponseUserRegister> AddUser(RequesteRegisterUser user);

	public Task<bool> Login(LoginUser user);

}
