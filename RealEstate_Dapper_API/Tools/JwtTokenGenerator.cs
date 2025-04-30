using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RealEstate_Dapper_API.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDTO GenerateToken(GetCheckAppUserDTO getCheckAppUserDTO)
        {
            var claims = new List<Claim>();

            if (!string.IsNullOrWhiteSpace(getCheckAppUserDTO.Role))
            {
                claims.Add(new Claim(ClaimTypes.Role,getCheckAppUserDTO.Role)); 
            }

            claims.Add(new Claim(ClaimTypes.NameIdentifier, getCheckAppUserDTO.ID.ToString()));
            
            if (!string.IsNullOrWhiteSpace(getCheckAppUserDTO.Username))
            {
                claims.Add(new Claim("Username",getCheckAppUserDTO.Username));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signinCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: JwtTokenDefaults.ValidIssuer, 
                audience: JwtTokenDefaults.ValidAudience, 
                claims: claims, 
                notBefore: DateTime.UtcNow,
                expires: expireDate, 
                signingCredentials: signinCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            return new TokenResponseDTO(tokenHandler.WriteToken(token), expireDate);
        }
    }
}
