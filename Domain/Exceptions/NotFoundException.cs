﻿namespace Places.Domain.Exceptions;

[ExcludeFromCodeCoverage]
[Serializable]
public class NotFoundException : BusinessException
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}