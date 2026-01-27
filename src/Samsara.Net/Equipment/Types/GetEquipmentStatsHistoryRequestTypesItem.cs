using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Equipment;

[JsonConverter(typeof(StringEnumSerializer<GetEquipmentStatsHistoryRequestTypesItem>))]
[Serializable]
public readonly record struct GetEquipmentStatsHistoryRequestTypesItem : IStringEnum
{
    public static readonly GetEquipmentStatsHistoryRequestTypesItem GatewayEngineStates = new(
        Values.GatewayEngineStates
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem ObdEngineStates = new(
        Values.ObdEngineStates
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem FuelPercents = new(
        Values.FuelPercents
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem EngineRpm = new(
        Values.EngineRpm
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem GatewayEngineSeconds = new(
        Values.GatewayEngineSeconds
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem GatewayJ1939EngineSeconds = new(
        Values.GatewayJ1939EngineSeconds
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem GpsOdometerMeters = new(
        Values.GpsOdometerMeters
    );

    public static readonly GetEquipmentStatsHistoryRequestTypesItem Gps = new(Values.Gps);

    public static readonly GetEquipmentStatsHistoryRequestTypesItem EngineTotalIdleTimeMinutes =
        new(Values.EngineTotalIdleTimeMinutes);

    public GetEquipmentStatsHistoryRequestTypesItem(string value)
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
    public static GetEquipmentStatsHistoryRequestTypesItem FromCustom(string value)
    {
        return new GetEquipmentStatsHistoryRequestTypesItem(value);
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
        GetEquipmentStatsHistoryRequestTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetEquipmentStatsHistoryRequestTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetEquipmentStatsHistoryRequestTypesItem value) =>
        value.Value;

    public static explicit operator GetEquipmentStatsHistoryRequestTypesItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string GatewayEngineStates = "gatewayEngineStates";

        public const string ObdEngineStates = "obdEngineStates";

        public const string FuelPercents = "fuelPercents";

        public const string EngineRpm = "engineRpm";

        public const string GatewayEngineSeconds = "gatewayEngineSeconds";

        public const string ObdEngineSeconds = "obdEngineSeconds";

        public const string GatewayJ1939EngineSeconds = "gatewayJ1939EngineSeconds";

        public const string GpsOdometerMeters = "gpsOdometerMeters";

        public const string Gps = "gps";

        public const string EngineTotalIdleTimeMinutes = "engineTotalIdleTimeMinutes";
    }
}
