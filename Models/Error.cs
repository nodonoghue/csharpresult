namespace ResultType.Models;

public class Error
{
    public Exception? Exception { get; set; }
    private readonly string? _message;
    public string? Message => _message ?? Exception?.Message;

    public Error(Exception exception)
    {
        Exception = exception;
    }

    public Error(string message)
    {
        _message = message;
    }
}