using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<IftaDetailJobResponseBodyJobStatus>))]
[Serializable]
public readonly record struct IftaDetailJobResponseBodyJobStatus : IStringEnum
{
    public static readonly IftaDetailJobResponseBodyJobStatus Requested = new(Values.Requested);

    public static readonly IftaDetailJobResponseBodyJobStatus Processing = new(Values.Processing);

    public static readonly IftaDetailJobResponseBodyJobStatus Completed = new(Values.Completed);

    public static readonly IftaDetailJobResponseBodyJobStatus Failed = new(Values.Failed);

    public IftaDetailJobResponseBodyJobStatus(string value)
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
    public static IftaDetailJobResponseBodyJobStatus FromCustom(string value)
    {
        return new IftaDetailJobResponseBodyJobStatus(value);
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

    public static bool operator ==(IftaDetailJobResponseBodyJobStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IftaDetailJobResponseBodyJobStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IftaDetailJobResponseBodyJobStatus value) => value.Value;

    public static explicit operator IftaDetailJobResponseBodyJobStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Requested = "Requested";

        public const string Processing = "Processing";

        public const string Completed = "Completed";

        public const string Failed = "Failed";
    }
}
