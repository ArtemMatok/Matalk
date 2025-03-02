using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatalkWebApi.Application.User.DTOs
{
    public record LoginDto(
        string Email,
        string Password
    );
}
