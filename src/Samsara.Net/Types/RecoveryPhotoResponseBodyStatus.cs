using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecoveryPhotoResponseBodyStatus>))]
[Serializable]
public readonly record struct RecoveryPhotoResponseBodyStatus : IStringEnum
{
    public static readonly RecoveryPhotoResponseBodyStatus Exists = new(Values.Exists);

    public static readonly RecoveryPhotoResponseBodyStatus NotFound = new(Values.NotFound);

    public static readonly RecoveryPhotoResponseBodyStatus ServerError = new(Values.ServerError);

    public RecoveryPhotoResponseBodyStatus(string value)
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
    public static RecoveryPhotoResponseBodyStatus FromCustom(string value)
    {
        return new RecoveryPhotoResponseBodyStatus(value);
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

    public static bool operator ==(RecoveryPhotoResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecoveryPhotoResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecoveryPhotoResponseBodyStatus value) => value.Value;

    public static explicit operator RecoveryPhotoResponseBodyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Exists = "EXISTS";

        public const string NotFound = "NOT_FOUND";

        public const string ServerError = "SERVER_ERROR";
    }
}
