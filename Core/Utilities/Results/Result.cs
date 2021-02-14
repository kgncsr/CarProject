﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)//sadece true false döndürsün ctor overloading
        {
            Success = success;
        }

        public bool Success { get; } //sadece okunabilir set özelliğini ctor

        public string Message { get; }
    }
}
