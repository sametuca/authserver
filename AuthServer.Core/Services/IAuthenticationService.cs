using System.Threading.Tasks;
using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);

        Task<Response<TokenDto>> CreateTokenByRefreshTokenAsync(LoginDto loginDto);

        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);

    }
}
