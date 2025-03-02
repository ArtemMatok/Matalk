using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatalkWebApi.Application.User.DTOs
{
    public record RegisterDto(
        string? UserName,
        string? Email,
        string? Password,
        string Role
    );
}
