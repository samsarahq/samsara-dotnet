using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementResponseObjectResponseBodyCreatedByParty>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementResponseObjectResponseBodyCreatedByParty
    : IStringEnum
{
    public static readonly AssetSharingAgreementResponseObjectResponseBodyCreatedByParty Provider =
        new(Values.Provider);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyCreatedByParty Recipient =
        new(Values.Recipient);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyCreatedByParty Unknown =
        new(Values.Unknown);

    public AssetSharingAgreementResponseObjectResponseBodyCreatedByParty(string value)
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
    public static AssetSharingAgreementResponseObjectResponseBodyCreatedByParty FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementResponseObjectResponseBodyCreatedByParty(value);
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
        AssetSharingAgreementResponseObjectResponseBodyCreatedByParty value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementResponseObjectResponseBodyCreatedByParty value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementResponseObjectResponseBodyCreatedByParty value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementResponseObjectResponseBodyCreatedByParty(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Provider = "provider";

        public const string Recipient = "recipient";

        public const string Unknown = "unknown";
    }
}
