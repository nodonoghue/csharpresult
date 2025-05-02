using System.Runtime.InteropServices.JavaScript;
using ResultType.Models;

namespace ResultType.BL;

public static class Logic
{
    public static Result<int> Divide(int numerator, int denominator)
    {
        Result<int> res;
        
        if (denominator == 0)
        {
            Exception exc = new DivideByZeroException();
            res = Result<int>.Err(exc);
            return res;
        }
        
        int result = numerator / denominator;
        res = Result<int>.Ok(result);
        return res;
    }
}
