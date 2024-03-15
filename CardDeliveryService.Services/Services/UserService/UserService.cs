using CardDeliveryService.DataAccess.Repositores;
using CardDeliveryService.Domain.Entities;
using CardDeliveryService.DTOs.UserModels;
using CardDeliveryService.Services.Extensions;
using CardDeliveryService.Services.Interfaces;

namespace CardDeliveryService.Services.Services.UserService;



public class UserService : IUserService
{
    private Repository<User> repository;
    public UserService(Repository<User> repository)
    {
        this.repository = repository;
    }
    public async ValueTask<UserViewModel> CreateUser(UserCreateModel user)
    {
        var createdUser = await repository.InsertAsync(user.MapTo<User>());
        return createdUser.MapTo<UserViewModel>();
    }

    public async ValueTask<bool> DeleteUser(long id)
    {
        var existUser = await repository.SelectByIdAsync(id)
            ?? throw new Exception("user is not found");

        await repository.DeleteAsync(existUser);
        return true;
    }

    public async ValueTask<IEnumerable<UserViewModel>> GetAllUsersAsync()
    {
        return repository.SelectAllAsEnumerable().MapTo<UserViewModel>();
    }

    public async ValueTask<User> GetToLogin(string email, string password)
    {
        var existUser = repository.SelectAllAsQueryable().FirstOrDefault(user => user.Email == email && user.Password == password)
            ?? throw new Exception("user is not found");

        return existUser;
    }

    public async ValueTask<User> GetUser(long id)
    {
        return await repository.SelectByIdAsync(id);
    }

    public async ValueTask<UserViewModel> UpdateUser(long id, UserUpdateModel user)
    {
        var existUser = await repository.SelectByIdAsync(id)
            ?? throw new Exception("user is not found");

        existUser.Email = user.Email;
        existUser.Password = user.Password;
        existUser.Firstname = user.Firstname;
        existUser.Lastname = user.Lastname;

        var updatedUser = await repository.UpdateAsync(existUser);
        return updatedUser.MapTo<UserViewModel>();
    }

    public async ValueTask<UserViewModel> ViewUser(long id)
    {
        var existUser = await repository.SelectByIdAsync(id)
            ?? throw new Exception("user is not found");

        return existUser.MapTo<UserViewModel>();
    }
}
