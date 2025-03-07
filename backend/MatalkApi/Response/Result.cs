﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string ErrorMessage { get; }
        public List<string> Errors { get; }

        private Result(T value, bool isSuccess, string errorMessage, List<string> errors)
        {
            Value = value;
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Errors = errors ?? new List<string>();
        }

        public static Result<T> Success(T value) => new Result<T>(value, true, null, null);

        public static Result<T> Failure(string errorMessage) => new Result<T>(default, false, errorMessage, null);
        public static Result<T> Failure(List<string> errors) => new Result<T>(default, false, null, errors);
    }

    public static class ResultExtensions
    {
        public static IActionResult ToResponse<T>(this Result<T> result)
        {
            var response = new ApiResponse<T>(result);

            if (result.IsSuccess)
            {
                return new OkObjectResult(response.Data);
            }
            else
            {
                return new BadRequestObjectResult(response);
            }
        }

    }
}
