using Microsoft.AspNetCore.Identity;

namespace NZ_Walk_WebAPI.Repository
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
        
    }
}
  