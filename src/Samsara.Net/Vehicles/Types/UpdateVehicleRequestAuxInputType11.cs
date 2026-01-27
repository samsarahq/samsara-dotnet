using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

[JsonConverter(typeof(StringEnumSerializer<UpdateVehicleRequestAuxInputType11>))]
[Serializable]
public readonly record struct UpdateVehicleRequestAuxInputType11 : IStringEnum
{
    public static readonly UpdateVehicleRequestAuxInputType11 None = new(Values.None);

    public static readonly UpdateVehicleRequestAuxInputType11 EmergencyLights = new(
        Values.EmergencyLights
    );

    public static readonly UpdateVehicleRequestAuxInputType11 EmergencyAlarm = new(
        Values.EmergencyAlarm
    );

    public static readonly UpdateVehicleRequestAuxInputType11 StopPaddle = new(Values.StopPaddle);

    public static readonly UpdateVehicleRequestAuxInputType11 PowerTakeOff = new(
        Values.PowerTakeOff
    );

    public static readonly UpdateVehicleRequestAuxInputType11 Plow = new(Values.Plow);

    public static readonly UpdateVehicleRequestAuxInputType11 Sweeper = new(Values.Sweeper);

    public static readonly UpdateVehicleRequestAuxInputType11 Salter = new(Values.Salter);

    public static readonly UpdateVehicleRequestAuxInputType11 Reefer = new(Values.Reefer);

    public static readonly UpdateVehicleRequestAuxInputType11 Door = new(Values.Door);

    public static readonly UpdateVehicleRequestAuxInputType11 Boom = new(Values.Boom);

    public static readonly UpdateVehicleRequestAuxInputType11 AuxiliaryEngine = new(
        Values.AuxiliaryEngine
    );

    public static readonly UpdateVehicleRequestAuxInputType11 Generator = new(Values.Generator);

    public static readonly UpdateVehicleRequestAuxInputType11 EightWayLights = new(
        Values.EightWayLights
    );

    public static readonly UpdateVehicleRequestAuxInputType11 PanicButton = new(Values.PanicButton);

    public static readonly UpdateVehicleRequestAuxInputType11 PrivacyButton = new(
        Values.PrivacyButton
    );

    public static readonly UpdateVehicleRequestAuxInputType11 FrontAxleDrive = new(
        Values.FrontAxleDrive
    );

    public static readonly UpdateVehicleRequestAuxInputType11 WeightSensor = new(
        Values.WeightSensor
    );

    public static readonly UpdateVehicleRequestAuxInputType11 Other = new(Values.Other);

    public static readonly UpdateVehicleRequestAuxInputType11 SecondaryFuelSource = new(
        Values.SecondaryFuelSource
    );

    public static readonly UpdateVehicleRequestAuxInputType11 EcuPowerTakeOff = new(
        Values.EcuPowerTakeOff
    );

    public UpdateVehicleRequestAuxInputType11(string value)
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
    public static UpdateVehicleRequestAuxInputType11 FromCustom(string value)
    {
        return new UpdateVehicleRequestAuxInputType11(value);
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

    public static bool operator ==(UpdateVehicleRequestAuxInputType11 value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateVehicleRequestAuxInputType11 value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateVehicleRequestAuxInputType11 value) => value.Value;

    public static explicit operator UpdateVehicleRequestAuxInputType11(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string None = "none";

        public const string EmergencyLights = "emergencyLights";

        public const string EmergencyAlarm = "emergencyAlarm";

        public const string StopPaddle = "stopPaddle";

        public const string PowerTakeOff = "powerTakeOff";

        public const string Plow = "plow";

        public const string Sweeper = "sweeper";

        public const string Salter = "salter";

        public const string Reefer = "reefer";

        public const string Door = "door";

        public const string Boom = "boom";

        public const string AuxiliaryEngine = "auxiliaryEngine";

        public const string Generator = "generator";

        public const string EightWayLights = "eightWayLights";

        public const string PanicButton = "panicButton";

        public const string PrivacyButton = "privacyButton";

        public const string FrontAxleDrive = "frontAxleDrive";

        public const string WeightSensor = "weightSensor";

        public const string Other = "other";

        public const string SecondaryFuelSource = "secondaryFuelSource";

        public const string EcuPowerTakeOff = "ecuPowerTakeOff";
    }
}
