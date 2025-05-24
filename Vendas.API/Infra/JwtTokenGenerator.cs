using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.IdentityModel.Tokens;

using Vendas.API.Interface;

namespace Vendas.API.Infra;

public class JwtTokenGenerator : IGeneratorToken
{
  private readonly uint _expirationTimeOrDate;
  private readonly string? _secretKey;

  public JwtTokenGenerator(uint expirationTimeOrDate, string? secretKey)
  {
    _expirationTimeOrDate = expirationTimeOrDate;
    _secretKey = secretKey;
  }

  public string GenerateToken(Guid userIdentier)
  {
    List<Claim> claim =
    [
      new Claim(ClaimTypes.Sid, userIdentier.ToString()),
    ];

    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity(claim),
      Expires = DateTime.UtcNow.AddMinutes(_expirationTimeOrDate),
      SigningCredentials = new SigningCredentials(SecurityKey(), SecurityAlgorithms.HmacSha256Signature),
    };

    var tokenHanlder = new JwtSecurityTokenHandler();
    var securityToken = tokenHanlder.CreateToken(tokenDescriptor);
    return tokenHanlder.WriteToken(securityToken);
  }

  private SymmetricSecurityKey SecurityKey()
  {
    byte[] bytes = Encoding.UTF8.GetBytes(_secretKey!);
    return new SymmetricSecurityKey(bytes);
  }
}
