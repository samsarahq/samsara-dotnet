using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementResponseObjectResponseBodyCanceledByParty>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementResponseObjectResponseBodyCanceledByParty
    : IStringEnum
{
    public static readonly AssetSharingAgreementResponseObjectResponseBodyCanceledByParty Provider =
        new(Values.Provider);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyCanceledByParty Recipient =
        new(Values.Recipient);

    public AssetSharingAgreementResponseObjectResponseBodyCanceledByParty(string value)
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
    public static AssetSharingAgreementResponseObjectResponseBodyCanceledByParty FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementResponseObjectResponseBodyCanceledByParty(value);
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
        AssetSharingAgreementResponseObjectResponseBodyCanceledByParty value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementResponseObjectResponseBodyCanceledByParty value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementResponseObjectResponseBodyCanceledByParty value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementResponseObjectResponseBodyCanceledByParty(
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
    }
}
