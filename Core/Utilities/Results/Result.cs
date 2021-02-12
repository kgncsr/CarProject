using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; } //sadece okunabilir set özelliğini ctor

        public string Message { get; }
    }
}
