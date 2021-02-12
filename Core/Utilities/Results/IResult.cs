using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {//void operasyonlarım icin
        bool Success { get; }
        string Message { get; }
    }
}
