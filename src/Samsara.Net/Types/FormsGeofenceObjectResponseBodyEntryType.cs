using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsGeofenceObjectResponseBodyEntryType>))]
[Serializable]
public readonly record struct FormsGeofenceObjectResponseBodyEntryType : IStringEnum
{
    public static readonly FormsGeofenceObjectResponseBodyEntryType Tracked = new(Values.Tracked);

    public static readonly FormsGeofenceObjectResponseBodyEntryType Untracked = new(
        Values.Untracked
    );

    public FormsGeofenceObjectResponseBodyEntryType(string value)
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
    public static FormsGeofenceObjectResponseBodyEntryType FromCustom(string value)
    {
        return new FormsGeofenceObjectResponseBodyEntryType(value);
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
        FormsGeofenceObjectResponseBodyEntryType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsGeofenceObjectResponseBodyEntryType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormsGeofenceObjectResponseBodyEntryType value) =>
        value.Value;

    public static explicit operator FormsGeofenceObjectResponseBodyEntryType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Tracked = "tracked";

        public const string Untracked = "untracked";
    }
}
