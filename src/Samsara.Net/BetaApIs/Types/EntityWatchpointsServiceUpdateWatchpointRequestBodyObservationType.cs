using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType>)
)]
[Serializable]
public readonly record struct EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType
    : IStringEnum
{
    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType RoadDefect =
        new(Values.RoadDefect);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType UtilityCut =
        new(Values.UtilityCut);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Guardrail =
        new(Values.Guardrail);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Streetlight =
        new(Values.Streetlight);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Signage =
        new(Values.Signage);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType StormDrain =
        new(Values.StormDrain);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Graffiti =
        new(Values.Graffiti);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Vegetation =
        new(Values.Vegetation);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Blight =
        new(Values.Blight);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType IllegalDumping =
        new(Values.IllegalDumping);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Littering =
        new(Values.Littering);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType HighVegetationWeeds =
        new(Values.HighVegetationWeeds);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Fire =
        new(Values.Fire);

    public static readonly EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType Other =
        new(Values.Other);

    public EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType(string value)
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
    public static EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType FromCustom(
        string value
    )
    {
        return new EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType(value);
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
        EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType value
    ) => value.Value;

    public static explicit operator EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RoadDefect = "roadDefect";

        public const string UtilityCut = "utilityCut";

        public const string Guardrail = "guardrail";

        public const string Streetlight = "streetlight";

        public const string Signage = "signage";

        public const string StormDrain = "stormDrain";

        public const string Graffiti = "graffiti";

        public const string Vegetation = "vegetation";

        public const string Blight = "blight";

        public const string IllegalDumping = "illegalDumping";

        public const string Littering = "littering";

        public const string HighVegetationWeeds = "highVegetationWeeds";

        public const string Fire = "fire";

        public const string Other = "other";
    }
}
