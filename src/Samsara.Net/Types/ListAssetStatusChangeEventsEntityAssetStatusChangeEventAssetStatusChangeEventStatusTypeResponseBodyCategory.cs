using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory>)
)]
[Serializable]
public readonly record struct ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory
    : IStringEnum
{
    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory Unknown =
        new(Values.Unknown);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory Operational =
        new(Values.Operational);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory Down =
        new(Values.Down);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory Disposed =
        new(Values.Disposed);

    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory(
        string value
    )
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
    public static ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory FromCustom(
        string value
    )
    {
        return new ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory(
            value
        );
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
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory value
    ) => value.Value;

    public static explicit operator ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBodyCategory(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Operational = "operational";

        public const string Down = "down";

        public const string Disposed = "disposed";
    }
}
