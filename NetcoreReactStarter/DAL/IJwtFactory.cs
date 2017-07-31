using System.Security.Claims;
using System.Threading.Tasks;

namespace NetcoreReactStarter.DAL
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
    }
}
