﻿using MatalkWebApi.Application.User.DTOs;
using Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatalkWebApi.Application.User.Interfaces
{
    public interface IAuthenticationService
    {
        Task<Result<NewUserDto>> Register(RegisterDto registerDto);
        Task<Result<NewUserDto>> Login(LoginDto loginDto);
    }
}
