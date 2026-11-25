using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType>)
)]
[Serializable]
public readonly record struct UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType
    : IStringEnum
{
    public static readonly UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType Unknown =
        new(Values.Unknown);

    public static readonly UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType User =
        new(Values.User);

    public static readonly UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType System =
        new(Values.System);

    public static readonly UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType ApiToken =
        new(Values.ApiToken);

    public UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(string value)
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
    public static UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType FromCustom(
        string value
    )
    {
        return new UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(
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
        UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType value
    ) => value.Value;

    public static explicit operator UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType(
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
