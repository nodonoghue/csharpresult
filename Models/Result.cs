namespace ResultType.Models;

public class Result<T>
{
    public T Value { get; } = default!;
    public Error? Error { get; set; }
    public bool IsSuccess { get; set; }

    private Result(T value)
    { 
        Value = value;
        IsSuccess = true;
    }

    private Result(Error error)
    {
        Error = error;
        IsSuccess = false;
    }
    
    public static Result<T> Ok(T value) => new(value);
    public static Result<T> Err(string error)
    {
        Error err = new Error(error);
        return new Result<T>(err);
    }

    public static Result<T> Err(Exception error)
    {
        Error err = new Error(error);
        return new Result<T>(err);
    }
}

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