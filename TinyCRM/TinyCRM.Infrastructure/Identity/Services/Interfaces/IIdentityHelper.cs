﻿namespace TinyCRM.Infrastructure.Identity.Services.Interfaces
{
    public interface IIdentityHelper
    {
        Task<ApplicationUser> GetApplicationUserByIdAsync(string userId);
    }
}