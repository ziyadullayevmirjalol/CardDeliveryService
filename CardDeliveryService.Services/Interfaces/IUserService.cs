﻿using CardDeliveryService.Domain.Entities;
using CardDeliveryService.DTOs.UserModels;

namespace CardDeliveryService.Services.Interfaces;

public interface IUserService
{
    public ValueTask<UserViewModel> CreateUser(UserCreateModel user);
    public ValueTask<UserViewModel> UpdateUser(long id, UserUpdateModel user);
    public ValueTask<bool> DeleteUser(long id);
    public ValueTask<User> GetUser(long id);
    public ValueTask<User> GetToLogin(string email, string password);
    public ValueTask<UserViewModel> ViewUser(long id);
    public ValueTask<IEnumerable<UserViewModel>> GetAllUsersAsync();
}
