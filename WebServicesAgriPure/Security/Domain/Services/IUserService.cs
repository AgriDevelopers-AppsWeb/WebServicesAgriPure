using WebServicesAgriPure.Security.Domain.Models;
using WebServicesAgriPure.Security.Services.Communication;

namespace WebServicesAgriPure.Security.Domain.Services;

public interface IUserService
{
    Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
    Task<IEnumerable<User>> ListAsync();
    Task<User> GetByIdAsync(int id);
    Task RegisterAsync(RegisterRequest model);
    Task UpdateAsync(int id, UpdateRequest model);
    Task DeleteAsync(int id);

}