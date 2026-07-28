using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateWatchpointTypeResponseBodyObservationType>))]
[Serializable]
public readonly record struct EntityCreateWatchpointTypeResponseBodyObservationType : IStringEnum
{
    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType RoadDefect = new(
        Values.RoadDefect
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType UtilityCut = new(
        Values.UtilityCut
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Guardrail = new(
        Values.Guardrail
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Streetlight = new(
        Values.Streetlight
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Signage = new(
        Values.Signage
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType StormDrain = new(
        Values.StormDrain
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Graffiti = new(
        Values.Graffiti
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Vegetation = new(
        Values.Vegetation
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Blight = new(
        Values.Blight
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType IllegalDumping =
        new(Values.IllegalDumping);

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Littering = new(
        Values.Littering
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType HighVegetationWeeds =
        new(Values.HighVegetationWeeds);

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Fire = new(
        Values.Fire
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyObservationType Other = new(
        Values.Other
    );

    public EntityCreateWatchpointTypeResponseBodyObservationType(string value)
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
    public static EntityCreateWatchpointTypeResponseBodyObservationType FromCustom(string value)
    {
        return new EntityCreateWatchpointTypeResponseBodyObservationType(value);
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
        EntityCreateWatchpointTypeResponseBodyObservationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateWatchpointTypeResponseBodyObservationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreateWatchpointTypeResponseBodyObservationType value
    ) => value.Value;

    public static explicit operator EntityCreateWatchpointTypeResponseBodyObservationType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

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
