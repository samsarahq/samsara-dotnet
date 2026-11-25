using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType>)
)]
[Serializable]
public readonly record struct ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType
    : IStringEnum
{
    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType Unknown =
        new(Values.Unknown);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType User =
        new(Values.User);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType System =
        new(Values.System);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType ApiToken =
        new(Values.ApiToken);

    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType(
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
    public static ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType FromCustom(
        string value
    )
    {
        return new ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType(
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
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType value
    ) => value.Value;

    public static explicit operator ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBodyActorType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string User = "user";

        public const string System = "system";

        public const string ApiToken = "apiToken";
    }
}
