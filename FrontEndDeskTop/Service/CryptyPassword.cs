namespace FrontEndDeskTop.Service
{
	public static class CryptyPassword
	{
		public static string Encrypty(string password) => BCrypt.Net.BCrypt.HashPassword(password);
		public static bool Verify(string password, string hash) => BCrypt.Net.BCrypt.Verify(password, hash);
	}
}
