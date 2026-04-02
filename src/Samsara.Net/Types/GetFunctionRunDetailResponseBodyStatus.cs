using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GetFunctionRunDetailResponseBodyStatus>))]
[Serializable]
public readonly record struct GetFunctionRunDetailResponseBodyStatus : IStringEnum
{
    public static readonly GetFunctionRunDetailResponseBodyStatus Started = new(Values.Started);

    public static readonly GetFunctionRunDetailResponseBodyStatus Timeout = new(Values.Timeout);

    public static readonly GetFunctionRunDetailResponseBodyStatus Error = new(Values.Error);

    public static readonly GetFunctionRunDetailResponseBodyStatus Success = new(Values.Success);

    public static readonly GetFunctionRunDetailResponseBodyStatus Dropped = new(Values.Dropped);

    public GetFunctionRunDetailResponseBodyStatus(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static GetFunctionRunDetailResponseBodyStatus FromCustom(string value)
    {
        return new GetFunctionRunDetailResponseBodyStatus(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(GetFunctionRunDetailResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetFunctionRunDetailResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetFunctionRunDetailResponseBodyStatus value) =>
        value.Value;

    public static explicit operator GetFunctionRunDetailResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Started = "started";

        public const string Timeout = "timeout";

        public const string Error = "error";

        public const string Success = "success";

        public const string Dropped = "dropped";
    }
}
