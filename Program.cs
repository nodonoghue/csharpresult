using ResultType.Models;
using ResultType.BL;

Console.WriteLine("Starting result type demonstration terminal app...");

Console.WriteLine("give me values, N then D");
int num = Convert.ToInt32(Console.ReadLine());
int den = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Running test...");
Result<int> successRes = Logic.Divide(num, den);
if (!successRes.IsSuccess)
{
    Console.WriteLine($"Error: {successRes.Error?.Message}");
    return;
}
Console.WriteLine($"Success: {successRes.Value}");