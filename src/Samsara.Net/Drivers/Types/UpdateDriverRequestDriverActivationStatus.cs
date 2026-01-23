using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(StringEnumSerializer<UpdateDriverRequestDriverActivationStatus>))]
[Serializable]
public readonly record struct UpdateDriverRequestDriverActivationStatus : IStringEnum
{
    public static readonly UpdateDriverRequestDriverActivationStatus Active = new(Values.Active);

    public static readonly UpdateDriverRequestDriverActivationStatus Deactivated = new(
        Values.Deactivated
    );

    public UpdateDriverRequestDriverActivationStatus(string value)
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
    public static UpdateDriverRequestDriverActivationStatus FromCustom(string value)
    {
        return new UpdateDriverRequestDriverActivationStatus(value);
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

    public static bool operator ==(
        UpdateDriverRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateDriverRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateDriverRequestDriverActivationStatus value) =>
        value.Value;

    public static explicit operator UpdateDriverRequestDriverActivationStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Deactivated = "deactivated";
    }
}
