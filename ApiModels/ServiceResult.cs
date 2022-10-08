using System;

namespace ApiModels;

public class ServiceResult<T>
{
    public bool Success { get; set; }
    public T? Result { get; set; }
    public string? Message { get; set; }
    public Exception? Exception { get; set; }
}