using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ServiceTaskInstanceInputObjectRequestBodyStatus>))]
[Serializable]
public readonly record struct ServiceTaskInstanceInputObjectRequestBodyStatus : IStringEnum
{
    public static readonly ServiceTaskInstanceInputObjectRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly ServiceTaskInstanceInputObjectRequestBodyStatus Open = new(Values.Open);

    public static readonly ServiceTaskInstanceInputObjectRequestBodyStatus InProgress = new(
        Values.InProgress
    );

    public static readonly ServiceTaskInstanceInputObjectRequestBodyStatus OnHold = new(
        Values.OnHold
    );

    public static readonly ServiceTaskInstanceInputObjectRequestBodyStatus Completed = new(
        Values.Completed
    );

    public ServiceTaskInstanceInputObjectRequestBodyStatus(string value)
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
    public static ServiceTaskInstanceInputObjectRequestBodyStatus FromCustom(string value)
    {
        return new ServiceTaskInstanceInputObjectRequestBodyStatus(value);
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
        ServiceTaskInstanceInputObjectRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ServiceTaskInstanceInputObjectRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ServiceTaskInstanceInputObjectRequestBodyStatus value) =>
        value.Value;

    public static explicit operator ServiceTaskInstanceInputObjectRequestBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Open = "Open";

        public const string InProgress = "In Progress";

        public const string OnHold = "On Hold";

        public const string Completed = "Completed";
    }
}
