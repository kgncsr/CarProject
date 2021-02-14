using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {//datam ve resultum icin operasyonlar
        T Data { get; }
    }
}
