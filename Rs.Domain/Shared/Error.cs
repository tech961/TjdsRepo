﻿namespace Rs.Domain.Shared;

public class Error : IEquatable<Error>
{
    public static readonly Error None = new(null, string.Empty, string.Empty);
    public static readonly Error NullValue = new(null, "Error.NullValue", "The specified result value is null.");

    public Error(HttpErrorCode? httpCode, string code, string message)
    {
        Code = code;
        Message = message;
        HttpCode = httpCode;
    }

    public string Code { get; }
    public HttpErrorCode? HttpCode { get; set; }
    public string Message { get; }

    public static implicit operator string(Error error) => error.Code;

    public static bool operator ==(Error? a, Error? b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Error? a, Error? b) => !(a == b);

    public virtual bool Equals(Error? other)
    {
        if (other is null)
        {
            return false;
        }

        return Code == other.Code && Message == other.Message;
    }

    public override bool Equals(object? obj) => obj is Error error && Equals(error);

    public override int GetHashCode() => HashCode.Combine(Code, Message);

    public override string ToString() => Code;
}