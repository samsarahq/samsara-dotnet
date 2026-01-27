using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Equipment;

[JsonConverter(typeof(StringEnumSerializer<GetEquipmentStatsRequestTypesItem>))]
[Serializable]
public readonly record struct GetEquipmentStatsRequestTypesItem : IStringEnum
{
    public static readonly GetEquipmentStatsRequestTypesItem GatewayEngineStates = new(
        Values.GatewayEngineStates
    );

    public static readonly GetEquipmentStatsRequestTypesItem ObdEngineStates = new(
        Values.ObdEngineStates
    );

    public static readonly GetEquipmentStatsRequestTypesItem FuelPercents = new(
        Values.FuelPercents
    );

    public static readonly GetEquipmentStatsRequestTypesItem EngineRpm = new(Values.EngineRpm);

    public static readonly GetEquipmentStatsRequestTypesItem GatewayEngineSeconds = new(
        Values.GatewayEngineSeconds
    );

    public static readonly GetEquipmentStatsRequestTypesItem ObdEngineSeconds = new(
        Values.ObdEngineSeconds
    );

    public static readonly GetEquipmentStatsRequestTypesItem GatewayJ1939EngineSeconds = new(
        Values.GatewayJ1939EngineSeconds
    );

    public static readonly GetEquipmentStatsRequestTypesItem GpsOdometerMeters = new(
        Values.GpsOdometerMeters
    );

    public static readonly GetEquipmentStatsRequestTypesItem Gps = new(Values.Gps);

    public static readonly GetEquipmentStatsRequestTypesItem EngineTotalIdleTimeMinutes = new(
        Values.EngineTotalIdleTimeMinutes
    );

    public GetEquipmentStatsRequestTypesItem(string value)
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
    public static GetEquipmentStatsRequestTypesItem FromCustom(string value)
    {
        return new GetEquipmentStatsRequestTypesItem(value);
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

    public static bool operator ==(GetEquipmentStatsRequestTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetEquipmentStatsRequestTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetEquipmentStatsRequestTypesItem value) => value.Value;

    public static explicit operator GetEquipmentStatsRequestTypesItem(string value) => new(value);

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
