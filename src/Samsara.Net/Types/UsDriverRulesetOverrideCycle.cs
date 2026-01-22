using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UsDriverRulesetOverrideCycle>))]
[Serializable]
public readonly record struct UsDriverRulesetOverrideCycle : IStringEnum
{
    public static readonly UsDriverRulesetOverrideCycle UsaProperty870 = new(Values.UsaProperty870);

    public static readonly UsDriverRulesetOverrideCycle UsaProperty760 = new(Values.UsaProperty760);

    public static readonly UsDriverRulesetOverrideCycle UsaPassenger870 = new(
        Values.UsaPassenger870
    );

    public static readonly UsDriverRulesetOverrideCycle UsaPassenger760 = new(
        Values.UsaPassenger760
    );

    public static readonly UsDriverRulesetOverrideCycle AlaskaProperty880 = new(
        Values.AlaskaProperty880
    );

    public static readonly UsDriverRulesetOverrideCycle AlaskaProperty770 = new(
        Values.AlaskaProperty770
    );

    public static readonly UsDriverRulesetOverrideCycle AlaskaPassenger880 = new(
        Values.AlaskaPassenger880
    );

    public static readonly UsDriverRulesetOverrideCycle AlaskaPassenger770 = new(
        Values.AlaskaPassenger770
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaSchoolFlv880 = new(
        Values.CaliforniaSchoolFlv880
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaFarm8112 = new(
        Values.CaliforniaFarm8112
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaProperty880 = new(
        Values.CaliforniaProperty880
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaFlammableLiquid880 = new(
        Values.CaliforniaFlammableLiquid880
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaPassenger880 = new(
        Values.CaliforniaPassenger880
    );

    public static readonly UsDriverRulesetOverrideCycle CaliforniaMotionPicture880 = new(
        Values.CaliforniaMotionPicture880
    );

    public static readonly UsDriverRulesetOverrideCycle Florida880 = new(Values.Florida880);

    public static readonly UsDriverRulesetOverrideCycle Florida770 = new(Values.Florida770);

    public static readonly UsDriverRulesetOverrideCycle Nebraska880 = new(Values.Nebraska880);

    public static readonly UsDriverRulesetOverrideCycle Nebraska770 = new(Values.Nebraska770);

    public static readonly UsDriverRulesetOverrideCycle NorthCarolina880 = new(
        Values.NorthCarolina880
    );

    public static readonly UsDriverRulesetOverrideCycle NorthCarolina770 = new(
        Values.NorthCarolina770
    );

    public static readonly UsDriverRulesetOverrideCycle Oklahoma870 = new(Values.Oklahoma870);

    public static readonly UsDriverRulesetOverrideCycle Oklahoma760 = new(Values.Oklahoma760);

    public static readonly UsDriverRulesetOverrideCycle Oregon880 = new(Values.Oregon880);

    public static readonly UsDriverRulesetOverrideCycle Oregon770 = new(Values.Oregon770);

    public static readonly UsDriverRulesetOverrideCycle SouthCarolina880 = new(
        Values.SouthCarolina880
    );

    public static readonly UsDriverRulesetOverrideCycle SouthCarolina770 = new(
        Values.SouthCarolina770
    );

    public static readonly UsDriverRulesetOverrideCycle Texas770 = new(Values.Texas770);

    public static readonly UsDriverRulesetOverrideCycle Wisconsin880 = new(Values.Wisconsin880);

    public static readonly UsDriverRulesetOverrideCycle Wisconsin770 = new(Values.Wisconsin770);

    public UsDriverRulesetOverrideCycle(string value)
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
    public static UsDriverRulesetOverrideCycle FromCustom(string value)
    {
        return new UsDriverRulesetOverrideCycle(value);
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

    public static bool operator ==(UsDriverRulesetOverrideCycle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsDriverRulesetOverrideCycle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsDriverRulesetOverrideCycle value) => value.Value;

    public static explicit operator UsDriverRulesetOverrideCycle(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UsaProperty870 = "USA Property (8/70)";

        public const string UsaProperty760 = "USA Property (7/60)";

        public const string UsaPassenger870 = "USA Passenger (8/70)";

        public const string UsaPassenger760 = "USA Passenger (7/60)";

        public const string AlaskaProperty880 = "Alaska Property (8/80)";

        public const string AlaskaProperty770 = "Alaska Property (7/70)";

        public const string AlaskaPassenger880 = "Alaska Passenger (8/80)";

        public const string AlaskaPassenger770 = "Alaska Passenger (7/70)";

        public const string CaliforniaSchoolFlv880 = "California School/FLV (8/80)";

        public const string CaliforniaFarm8112 = "California Farm (8/112)";

        public const string CaliforniaProperty880 = "California Property (8/80)";

        public const string CaliforniaFlammableLiquid880 = "California Flammable Liquid (8/80)";

        public const string CaliforniaPassenger880 = "California Passenger (8/80)";

        public const string CaliforniaMotionPicture880 = "California Motion Picture (8/80)";

        public const string Florida880 = "Florida (8/80)";

        public const string Florida770 = "Florida (7/70)";

        public const string Nebraska880 = "Nebraska (8/80)";

        public const string Nebraska770 = "Nebraska (7/70)";

        public const string NorthCarolina880 = "North Carolina (8/80)";

        public const string NorthCarolina770 = "North Carolina (7/70)";

        public const string Oklahoma870 = "Oklahoma (8/70)";

        public const string Oklahoma760 = "Oklahoma (7/60)";

        public const string Oregon880 = "Oregon (8/80)";

        public const string Oregon770 = "Oregon (7/70)";

        public const string SouthCarolina880 = "South Carolina (8/80)";

        public const string SouthCarolina770 = "South Carolina (7/70)";

        public const string Texas770 = "Texas (7/70)";

        public const string Wisconsin880 = "Wisconsin (8/80)";

        public const string Wisconsin770 = "Wisconsin (7/70)";
    }
}
