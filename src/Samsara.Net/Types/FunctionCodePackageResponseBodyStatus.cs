using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FunctionCodePackageResponseBodyStatus>))]
[Serializable]
public readonly record struct FunctionCodePackageResponseBodyStatus : IStringEnum
{
    public static readonly FunctionCodePackageResponseBodyStatus Unknown = new(Values.Unknown);

    public static readonly FunctionCodePackageResponseBodyStatus PendingUpload = new(
        Values.PendingUpload
    );

    public static readonly FunctionCodePackageResponseBodyStatus Uploaded = new(Values.Uploaded);

    public static readonly FunctionCodePackageResponseBodyStatus Deployed = new(Values.Deployed);

    public FunctionCodePackageResponseBodyStatus(string value)
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
    public static FunctionCodePackageResponseBodyStatus FromCustom(string value)
    {
        return new FunctionCodePackageResponseBodyStatus(value);
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

    public static bool operator ==(FunctionCodePackageResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FunctionCodePackageResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FunctionCodePackageResponseBodyStatus value) =>
        value.Value;

    public static explicit operator FunctionCodePackageResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string PendingUpload = "pendingUpload";

        public const string Uploaded = "uploaded";

        public const string Deployed = "deployed";
    }
}
