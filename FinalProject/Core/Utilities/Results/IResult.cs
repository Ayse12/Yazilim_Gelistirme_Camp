using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //get okunabilir.
        //set yazılabilir.
        bool Success { get; }
        string Message { get; }
    }
}
