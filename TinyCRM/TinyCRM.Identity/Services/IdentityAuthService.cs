﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TinyCRM.Application.Common.Interfaces;
using TinyCRM.Application.Modules.Auth.DTOs;
using TinyCRM.Domain.Entities;
using TinyCRM.Domain.HttpExceptions;
using TinyCRM.Identity.Entities;
using TinyCRM.Identity.Services.Interfaces;

namespace TinyCRM.Identity.Services;

public class IdentityAuthService : IIdentityAuthService
{
    private readonly IIdentityHelper _identityHelper;
    private readonly IMapper _mapper;
    private readonly UserManager<ApplicationUser> _userManager;

    public IdentityAuthService(
        UserManager<ApplicationUser> userManager,
        IMapper mapper,
        IIdentityHelper identityHelper)
    {
        _userManager = userManager;
        _mapper = mapper;
        _identityHelper = identityHelper;
    }

    public async Task<UserEntity> AuthenticateUserAsync(LoginDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);

        if (user != null && await _userManager.CheckPasswordAsync(user, dto.Password))
            return _mapper.Map<UserEntity>(user);

        throw new BadRequestException("Email or password does not match");
    }

    public async Task UpdatePasswordAsync(string userId, string password)
    {
        var user = await _identityHelper.GetApplicationUserByIdAsync(userId);

        var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

        var result = await _userManager.ResetPasswordAsync(user, resetToken, password);

        if (!result.Succeeded) throw new BadRequestException(result.Errors.First().Description);
    }
}