using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType>)
)]
[Serializable]
public readonly record struct ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType
    : IStringEnum
{
    public static readonly ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType Unknown =
        new(Values.Unknown);

    public static readonly ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType User =
        new(Values.User);

    public static readonly ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType System =
        new(Values.System);

    public static readonly ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType ApiToken =
        new(Values.ApiToken);

    public ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(string value)
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
    public static ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType FromCustom(
        string value
    )
    {
        return new ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(
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
        ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value
    ) => value.Value;

    public static explicit operator ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(
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
