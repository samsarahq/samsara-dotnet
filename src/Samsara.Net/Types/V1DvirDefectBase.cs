using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirDefectBase
{
    /// <summary>
    /// The comment describing the type of DVIR defect.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The type of DVIR defect. Possible values: [`AIR_COMPRESSOR`, `AIR_CONDITIONER`, `AIR_LINES`, `BATTERY`, `BELTS_HOSES`, `BRAKE_ACCESSORIES`, `BRAKE_CHECK`, `BRAKE_CONNECTIONS`, `BRAKES`, `CLUTCH`, `COUPLING_DEVICES`, `DEFROSTER_HEATER`, `DOORS`, `DRIVE_LINE`, `EMERGENCY_DOOR_AND_BUZZER`, `ENGINE`, `ENTRANCE_STEPS`, `EXHAUST`, `FIFTH_WHEEL`, `FIRST_AID_KIT`, `FLUID_LEVELS`, `FRAME_ASSEMBLY`, `FRONT_AXLE`, `FUEL_TANKS`, `HORN`, `INTERIOR_AND_FLOOR`, `LANDING_GEAR`, `LIGHTS`, `MIRRORS`, `MUFFLER`, `OIL_PRESSURE`, `OTHER`, `RADIATOR`, `REAR_END`, `REFLECTORS`, `ROOF`, `SAFETY_EQUIPMENT`, `STARTER`, `STEERING`, `STOP_ARM_CONTROL`, `STOP_ARM`, `SUSPENSION`, `TIRE_CHAINS`, `TIRES`, `TRANSMISSION`, `TRIP_RECORDER`, `WHEELS_RIMS`, `WINDOWS`, `WINDSHIELD_WIPERS`, `UNSET`]
    /// </summary>
    [JsonPropertyName("defectType")]
    public string? DefectType { get; set; }

    /// <summary>
    /// The id of this defect.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Signifies if this defect is resolved.
    /// </summary>
    [JsonPropertyName("resolved")]
    public bool? Resolved { get; set; }

    /// <summary>
    /// Timestamp when this defect was resolved, in UNIX milliseconds.  Will not be returned if the defect is unresolved.
    /// </summary>
    [JsonPropertyName("resolvedAt")]
    public long? ResolvedAt { get; set; }

    /// <summary>
    /// ID of the driver who resolved this defect. Will not be returned if the defect is unresolved or resolvedByMechanicId is returned.
    /// </summary>
    [JsonPropertyName("resolvedByDriverId")]
    public long? ResolvedByDriverId { get; set; }

    /// <summary>
    /// ID of the mechanic who resolved this defect. Will not be returned if the defect is unresolved or resolvedByDriverId is returned.
    /// </summary>
    [JsonPropertyName("resolvedByMechanicId")]
    public long? ResolvedByMechanicId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
