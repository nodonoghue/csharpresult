using System.Runtime.InteropServices.JavaScript;

namespace ResultType.BL;

public static class Logic
{
    public static Models.Result<int> Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            Exception exc = new DivideByZeroException(); 
            return Models.Result<int>.Err(exc);
        }
        
        int result = numerator / denominator;
        return Models.Result<int>.Ok(result);
    }
}
