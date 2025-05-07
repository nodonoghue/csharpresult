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

        if (denominator < 0)
        {
            res = Result<int>.Err("Denominator cannot be negative");
            return res;
        }
        
        int result = numerator / denominator;
        res = Result<int>.Ok(result);
        return res;
    }
}
