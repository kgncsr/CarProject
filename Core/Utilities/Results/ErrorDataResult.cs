using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public  class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data,string message) : base(data,false,message)
        {

        }
        public ErrorDataResult(T data) : base(data,false)
        {

        }

        public ErrorDataResult(string message) : base(default,true,message) //default geri dönüs tipinde ne varsa demek (int,string...)
        {

        }

        public ErrorDataResult():base(default,true)
        {

        }


    }
}
