﻿namespace TinyCRM.Application.Common.Interfaces
{
    public interface IIdentityRoleService
    {
        Task AddToRoleAsync(string userId, string role);

        Task<IList<string>> GetRolesAsync(string userId);
    }
}