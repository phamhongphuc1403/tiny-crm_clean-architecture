﻿using Microsoft.AspNetCore.Authorization;
using StackExchange.Redis;
using TinyCRM.API.Authorization;
using TinyCRM.Application.Common.Interfaces;
using TinyCRM.Application.Modules.Account.Services;
using TinyCRM.Application.Modules.Account.Services.Interfaces;
using TinyCRM.Application.Modules.Auth.Services;
using TinyCRM.Application.Modules.Auth.Services.Interfaces;
using TinyCRM.Application.Modules.Contact.Services;
using TinyCRM.Application.Modules.Contact.Services.Interfaces;
using TinyCRM.Application.Modules.Deal.Services;
using TinyCRM.Application.Modules.Deal.Services.Interfaces;
using TinyCRM.Application.Modules.DealProduct.Services;
using TinyCRM.Application.Modules.DealProduct.Services.Interfaces;
using TinyCRM.Application.Modules.Lead.Services;
using TinyCRM.Application.Modules.Lead.Services.Interfaces;
using TinyCRM.Application.Modules.Permission.Services;
using TinyCRM.Application.Modules.Product.Services;
using TinyCRM.Application.Modules.Product.Services.Interfaces;
using TinyCRM.Application.Modules.Role.Services;
using TinyCRM.Application.Modules.Role.Services.Interfaces;
using TinyCRM.Application.Modules.User.Services;
using TinyCRM.Application.Modules.User.Services.Interfaces;
using TinyCRM.Domain;
using TinyCRM.Domain.Entities;
using TinyCRM.Domain.Repositories;
using TinyCRM.EntityFrameworkCore;
using TinyCRM.EntityFrameworkCore.Data;
using TinyCRM.EntityFrameworkCore.Repositories;
using TinyCRM.Identity.Services;
using TinyCRM.Identity.Services.Interfaces;
using TinyCRM.RedisCache;

namespace TinyCRM.API.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddDependencyInjectionExtension(this IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<ILeadService, LeadService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IDealService, DealService>();
        services.AddScoped<IDealProductService, DealProductService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IPermissionService, PermissionService>();

        services.AddScoped<IRepository<AccountEntity>, Repository<AccountEntity>>();
        services.AddScoped<IRepository<ContactEntity>, Repository<ContactEntity>>();
        services.AddScoped<IRepository<LeadEntity>, Repository<LeadEntity>>();
        services.AddScoped<IRepository<ProductEntity>, Repository<ProductEntity>>();
        services.AddScoped<IRepository<DealEntity>, Repository<DealEntity>>();
        services.AddScoped<IRepository<DealProductEntity>, Repository<DealProductEntity>>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IDealRepository, DealRepository>();
        services.AddScoped<IDealProductRepository, DealProductRepository>();
        services.AddScoped<ILeadRepository, LeadRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
        services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

        services.AddScoped<Func<AppDbContext>>(provider => () => provider.GetService<AppDbContext>()!);
        services.AddScoped<DbFactory>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IIdentityAuthService, IdentityAuthService>();
        services.AddScoped<IIdentityRoleService, IdentityRoleService>();
        services.AddScoped<IIdentityHelper, IdentityHelper>();

        var multiplexer = ConnectionMultiplexer.Connect(Environment.GetEnvironmentVariable("REDIS")!);
        services.AddSingleton<IConnectionMultiplexer>(multiplexer);
        services.AddScoped<ICacheService, RedisCacheService>();
        
        services.AddScoped<IPermissionCacheService, PermissionCacheService>();
        
        return services;
    }
}