using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator
    : IStringEnum
{
    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator Provider =
        new(Values.Provider);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator Recipient =
        new(Values.Recipient);

    public AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator(string value)
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
    public static AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator(value);
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
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator(
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
