using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateWatchpointTypeResponseBodyObservationType>))]
[Serializable]
public readonly record struct EntityUpdateWatchpointTypeResponseBodyObservationType : IStringEnum
{
    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType RoadDefect = new(
        Values.RoadDefect
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType UtilityCut = new(
        Values.UtilityCut
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Guardrail = new(
        Values.Guardrail
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Streetlight = new(
        Values.Streetlight
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Signage = new(
        Values.Signage
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType StormDrain = new(
        Values.StormDrain
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Graffiti = new(
        Values.Graffiti
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Vegetation = new(
        Values.Vegetation
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Blight = new(
        Values.Blight
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType IllegalDumping =
        new(Values.IllegalDumping);

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Littering = new(
        Values.Littering
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType HighVegetationWeeds =
        new(Values.HighVegetationWeeds);

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Fire = new(
        Values.Fire
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyObservationType Other = new(
        Values.Other
    );

    public EntityUpdateWatchpointTypeResponseBodyObservationType(string value)
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
    public static EntityUpdateWatchpointTypeResponseBodyObservationType FromCustom(string value)
    {
        return new EntityUpdateWatchpointTypeResponseBodyObservationType(value);
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
        EntityUpdateWatchpointTypeResponseBodyObservationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateWatchpointTypeResponseBodyObservationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdateWatchpointTypeResponseBodyObservationType value
    ) => value.Value;

    public static explicit operator EntityUpdateWatchpointTypeResponseBodyObservationType(
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
