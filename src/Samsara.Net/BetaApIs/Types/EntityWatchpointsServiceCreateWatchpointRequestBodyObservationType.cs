using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType>)
)]
[Serializable]
public readonly record struct EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType
    : IStringEnum
{
    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType RoadDefect =
        new(Values.RoadDefect);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType UtilityCut =
        new(Values.UtilityCut);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Guardrail =
        new(Values.Guardrail);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Streetlight =
        new(Values.Streetlight);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Signage =
        new(Values.Signage);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType StormDrain =
        new(Values.StormDrain);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Graffiti =
        new(Values.Graffiti);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Vegetation =
        new(Values.Vegetation);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Blight =
        new(Values.Blight);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType IllegalDumping =
        new(Values.IllegalDumping);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Littering =
        new(Values.Littering);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType HighVegetationWeeds =
        new(Values.HighVegetationWeeds);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Fire =
        new(Values.Fire);

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType Other =
        new(Values.Other);

    public EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType(string value)
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
    public static EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType FromCustom(
        string value
    )
    {
        return new EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType(value);
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
        EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType value
    ) => value.Value;

    public static explicit operator EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType(
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
