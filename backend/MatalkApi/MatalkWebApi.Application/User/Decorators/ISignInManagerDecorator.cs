﻿using MatalkWebApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatalkWebApi.Application.User.Decorators
{
    public interface ISignInManagerDecorator<T> where T : AppUser
    {
        Task<SignInResult> CheckPasswordSignInAsync(T user, string password, bool lockoutOnFailure);
    }
}
