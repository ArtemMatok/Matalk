﻿using MatalkWebApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatalkWebApi.Application.User.Decorators
{
    public class UserManagerDecorator<T> : IUserManagerDecorator<T> where T : AppUser
    {
        private readonly UserManager<T> _userManager;

        public UserManagerDecorator(UserManager<T> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddToRoleAsync(T user, string userRole)
        {
            return await _userManager.AddToRoleAsync(user, userRole);
        }

        public async Task<bool> CheckPasswordAsync(T user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IdentityResult> CreateAsync(T user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<T> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<IList<string>> GetRolesAsync(T user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<IList<string>?> GetUserRoles(T user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<bool> IsInRoleAsync(string userId, string role)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                return false;
            }

            return await _userManager.IsInRoleAsync(user, role);
        }
    }
}
