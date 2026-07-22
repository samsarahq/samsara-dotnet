using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem
    : IStringEnum
{
    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem Safety =
        new(Values.Safety);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem Telematics =
        new(Values.Telematics);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem Location =
        new(Values.Location);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem Maintenance =
        new(Values.Maintenance);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem Reefer =
        new(Values.Reefer);

    public static readonly AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem All =
        new(Values.All);

    public AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem(string value)
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
    public static AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem(value);
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
        AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Safety = "safety";

        public const string Telematics = "telematics";

        public const string Location = "location";

        public const string Maintenance = "maintenance";

        public const string Reefer = "reefer";

        public const string All = "all";
    }
}
