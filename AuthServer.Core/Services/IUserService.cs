using SharedLibrary.Dtos;
using System.Threading.Tasks;
using AuthServer.Core.DTOs;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto userDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);

    }
}
