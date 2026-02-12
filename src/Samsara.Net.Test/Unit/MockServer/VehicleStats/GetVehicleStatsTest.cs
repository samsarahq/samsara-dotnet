using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.VehicleStats;

namespace Samsara.Net.Test.Unit.MockServer.VehicleStats;

[TestFixture]
public class GetVehicleStatsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "ambientAirTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "auxInput1": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput10": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput11": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput12": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput13": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput2": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput3": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput4": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput5": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput6": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput7": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput8": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput9": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "barometricPressurePa": {
                    "time": "time",
                    "value": 1000000
                  },
                  "batteryMilliVolts": {
                    "time": "time",
                    "value": 1000000
                  },
                  "defLevelMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "ecuDoorStatus": {
                    "time": "time",
                    "value": "Closed"
                  },
                  "ecuSpeedMph": {
                    "time": "time",
                    "value": 1.1
                  },
                  "engineCoolantTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineImmobilizer": {
                    "connected": true,
                    "state": "ignition_disabled",
                    "time": "time"
                  },
                  "engineLoadPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineOilPressureKPa": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineRpm": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "evAverageBatteryTemperatureMilliCelsius": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryCurrentMilliAmp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryStateOfHealthMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryVoltageMilliVolt": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingCurrentMilliAmp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingStatus": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingVoltageMilliVolt": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evConsumedEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evDistanceDrivenMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evRegeneratedEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evStateOfChargeMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "externalIds": {
                    "externalIds": {
                      "key": "value"
                    }
                  },
                  "faultCodes": {
                    "canBusType": "canBusType",
                    "j1939": {
                      "checkEngineLights": {
                        "emissionsIsOn": true,
                        "protectIsOn": true,
                        "stopIsOn": true,
                        "warningIsOn": true
                      },
                      "diagnosticTroubleCodes": [
                        {
                          "fmiId": 1,
                          "milStatus": 1,
                          "occurrenceCount": 1,
                          "spnId": 1,
                          "txId": 1
                        },
                        {
                          "fmiId": 1,
                          "milStatus": 1,
                          "occurrenceCount": 1,
                          "spnId": 1,
                          "txId": 1
                        }
                      ]
                    },
                    "obdii": {
                      "checkEngineLightIsOn": true,
                      "diagnosticTroubleCodes": [
                        {
                          "txId": 1
                        },
                        {
                          "txId": 1
                        }
                      ]
                    },
                    "oem": {
                      "diagnosticTroubleCodes": [
                        {},
                        {}
                      ]
                    },
                    "time": "time"
                  },
                  "fuelConsumedMilliliters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "fuelPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gps": {
                    "address": {
                      "id": "id",
                      "name": "name"
                    },
                    "headingDegrees": 1.1,
                    "isEcuSpeed": true,
                    "latitude": 1.1,
                    "longitude": 1.1,
                    "reverseGeo": {
                      "formattedLocation": "formattedLocation"
                    },
                    "speedMilesPerHour": 1.1,
                    "time": "time"
                  },
                  "gpsDistanceMeters": {
                    "time": "time",
                    "value": 1.1
                  },
                  "gpsOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "id": "id",
                  "idlingDurationMilliseconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "intakeManifoldTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "name": "name",
                  "nfcCardScan": {
                    "card": {
                      "id": "id"
                    },
                    "time": "time"
                  },
                  "obdEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "obdOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "seatbeltDriver": {
                    "time": "time",
                    "value": "Buckled"
                  },
                  "spreaderActive": {
                    "time": "time",
                    "value": "Off"
                  },
                  "spreaderAirTemp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderBlastState": {
                    "time": "time",
                    "value": "On"
                  },
                  "spreaderGranularName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderGranularRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderLiquidName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderLiquidRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderOnState": {
                    "time": "time",
                    "value": "On"
                  },
                  "spreaderPlowStatus": {
                    "time": "time",
                    "value": "Up"
                  },
                  "spreaderPrewetName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderPrewetRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderRoadTemp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "syntheticEngineSeconds": {
                    "decorations": {
                      "ambientAirTemperatureMilliC": {
                        "value": 1000000
                      },
                      "auxInput1": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput10": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput11": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput12": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput13": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput2": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput3": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput4": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput5": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput6": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput7": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput8": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput9": {
                        "name": "name",
                        "value": true
                      },
                      "barometricPressurePa": {
                        "value": 1000000
                      },
                      "batteryMilliVolts": {
                        "value": 1000000
                      },
                      "defLevelMilliPercent": {
                        "value": 1000000
                      },
                      "ecuDoorStatus": {
                        "time": "time",
                        "value": "Closed"
                      },
                      "ecuSpeedMph": {
                        "value": 1.1
                      },
                      "engineCoolantTemperatureMilliC": {
                        "value": 1000000
                      },
                      "engineImmobilizer": {
                        "connected": true,
                        "state": "ignition_disabled",
                        "time": "time"
                      },
                      "engineLoadPercent": {
                        "value": 1000000
                      },
                      "engineOilPressureKPa": {
                        "value": 1000000
                      },
                      "engineRpm": {
                        "value": 1000000
                      },
                      "engineStates": {
                        "value": "Off"
                      },
                      "evAverageBatteryTemperatureMilliCelsius": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryCurrentMilliAmp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryStateOfHealthMilliPercent": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryVoltageMilliVolt": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingCurrentMilliAmp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingStatus": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingVoltageMilliVolt": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evConsumedEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evDistanceDrivenMeters": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evRegeneratedEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evStateOfChargeMilliPercent": {
                        "time": "time",
                        "value": 1000000
                      },
                      "faultCodes": {
                        "canBusType": "canBusType",
                        "j1939": {},
                        "obdii": {},
                        "oem": {}
                      },
                      "fuelConsumedMilliliters": {
                        "value": 1000000
                      },
                      "fuelPercents": {
                        "value": 1000000
                      },
                      "gps": {
                        "address": {},
                        "headingDegrees": 1.1,
                        "isEcuSpeed": true,
                        "latitude": 1.1,
                        "longitude": 1.1,
                        "reverseGeo": {},
                        "speedMilesPerHour": 1.1
                      },
                      "gpsDistanceMeters": {
                        "value": 1.1
                      },
                      "gpsOdometerMeters": {
                        "value": 1000000
                      },
                      "idlingDurationMilliseconds": {
                        "value": 1000000
                      },
                      "intakeManifoldTemperatureMilliC": {
                        "value": 1000000
                      },
                      "obdEngineSeconds": {
                        "value": 1000000
                      },
                      "obdOdometerMeters": {
                        "value": 1000000
                      },
                      "seatbeltDriver": {
                        "time": "time",
                        "value": "Buckled"
                      },
                      "spreaderActive": {
                        "time": "time",
                        "value": "Off"
                      },
                      "spreaderAirTemp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderBlastState": {
                        "time": "time",
                        "value": "On"
                      },
                      "spreaderGranularName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderGranularRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderLiquidName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderLiquidRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderOnState": {
                        "time": "time",
                        "value": "On"
                      },
                      "spreaderPlowStatus": {
                        "time": "time",
                        "value": "Up"
                      },
                      "spreaderPrewetName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderPrewetRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderRoadTemp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "tirePressure": {
                        "backLeftTirePressureKPa": 1000000,
                        "backRightTirePressureKPa": 1000000,
                        "frontLeftTirePressureKPa": 1000000,
                        "frontRightTirePressureKPa": 1000000
                      }
                    },
                    "time": "time",
                    "value": 1000000
                  }
                },
                {
                  "ambientAirTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "auxInput1": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput10": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput11": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput12": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput13": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput2": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput3": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput4": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput5": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput6": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput7": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput8": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "auxInput9": {
                    "name": "name",
                    "time": "time",
                    "value": true
                  },
                  "barometricPressurePa": {
                    "time": "time",
                    "value": 1000000
                  },
                  "batteryMilliVolts": {
                    "time": "time",
                    "value": 1000000
                  },
                  "defLevelMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "ecuDoorStatus": {
                    "time": "time",
                    "value": "Closed"
                  },
                  "ecuSpeedMph": {
                    "time": "time",
                    "value": 1.1
                  },
                  "engineCoolantTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineImmobilizer": {
                    "connected": true,
                    "state": "ignition_disabled",
                    "time": "time"
                  },
                  "engineLoadPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineOilPressureKPa": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineRpm": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "evAverageBatteryTemperatureMilliCelsius": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryCurrentMilliAmp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryStateOfHealthMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evBatteryVoltageMilliVolt": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingCurrentMilliAmp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingStatus": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evChargingVoltageMilliVolt": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evConsumedEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evDistanceDrivenMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evRegeneratedEnergyMicroWh": {
                    "time": "time",
                    "value": 1000000
                  },
                  "evStateOfChargeMilliPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "externalIds": {
                    "externalIds": {
                      "key": "value"
                    }
                  },
                  "faultCodes": {
                    "canBusType": "canBusType",
                    "j1939": {
                      "checkEngineLights": {
                        "emissionsIsOn": true,
                        "protectIsOn": true,
                        "stopIsOn": true,
                        "warningIsOn": true
                      },
                      "diagnosticTroubleCodes": [
                        {
                          "fmiId": 1,
                          "milStatus": 1,
                          "occurrenceCount": 1,
                          "spnId": 1,
                          "txId": 1
                        },
                        {
                          "fmiId": 1,
                          "milStatus": 1,
                          "occurrenceCount": 1,
                          "spnId": 1,
                          "txId": 1
                        }
                      ]
                    },
                    "obdii": {
                      "checkEngineLightIsOn": true,
                      "diagnosticTroubleCodes": [
                        {
                          "txId": 1
                        },
                        {
                          "txId": 1
                        }
                      ]
                    },
                    "oem": {
                      "diagnosticTroubleCodes": [
                        {},
                        {}
                      ]
                    },
                    "time": "time"
                  },
                  "fuelConsumedMilliliters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "fuelPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gps": {
                    "address": {
                      "id": "id",
                      "name": "name"
                    },
                    "headingDegrees": 1.1,
                    "isEcuSpeed": true,
                    "latitude": 1.1,
                    "longitude": 1.1,
                    "reverseGeo": {
                      "formattedLocation": "formattedLocation"
                    },
                    "speedMilesPerHour": 1.1,
                    "time": "time"
                  },
                  "gpsDistanceMeters": {
                    "time": "time",
                    "value": 1.1
                  },
                  "gpsOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "id": "id",
                  "idlingDurationMilliseconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "intakeManifoldTemperatureMilliC": {
                    "time": "time",
                    "value": 1000000
                  },
                  "name": "name",
                  "nfcCardScan": {
                    "card": {
                      "id": "id"
                    },
                    "time": "time"
                  },
                  "obdEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "obdOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "seatbeltDriver": {
                    "time": "time",
                    "value": "Buckled"
                  },
                  "spreaderActive": {
                    "time": "time",
                    "value": "Off"
                  },
                  "spreaderAirTemp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderBlastState": {
                    "time": "time",
                    "value": "On"
                  },
                  "spreaderGranularName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderGranularRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderLiquidName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderLiquidRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderOnState": {
                    "time": "time",
                    "value": "On"
                  },
                  "spreaderPlowStatus": {
                    "time": "time",
                    "value": "Up"
                  },
                  "spreaderPrewetName": {
                    "time": "time",
                    "value": "value"
                  },
                  "spreaderPrewetRate": {
                    "time": "time",
                    "value": 1000000
                  },
                  "spreaderRoadTemp": {
                    "time": "time",
                    "value": 1000000
                  },
                  "syntheticEngineSeconds": {
                    "decorations": {
                      "ambientAirTemperatureMilliC": {
                        "value": 1000000
                      },
                      "auxInput1": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput10": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput11": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput12": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput13": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput2": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput3": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput4": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput5": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput6": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput7": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput8": {
                        "name": "name",
                        "value": true
                      },
                      "auxInput9": {
                        "name": "name",
                        "value": true
                      },
                      "barometricPressurePa": {
                        "value": 1000000
                      },
                      "batteryMilliVolts": {
                        "value": 1000000
                      },
                      "defLevelMilliPercent": {
                        "value": 1000000
                      },
                      "ecuDoorStatus": {
                        "time": "time",
                        "value": "Closed"
                      },
                      "ecuSpeedMph": {
                        "value": 1.1
                      },
                      "engineCoolantTemperatureMilliC": {
                        "value": 1000000
                      },
                      "engineImmobilizer": {
                        "connected": true,
                        "state": "ignition_disabled",
                        "time": "time"
                      },
                      "engineLoadPercent": {
                        "value": 1000000
                      },
                      "engineOilPressureKPa": {
                        "value": 1000000
                      },
                      "engineRpm": {
                        "value": 1000000
                      },
                      "engineStates": {
                        "value": "Off"
                      },
                      "evAverageBatteryTemperatureMilliCelsius": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryCurrentMilliAmp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryStateOfHealthMilliPercent": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evBatteryVoltageMilliVolt": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingCurrentMilliAmp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingStatus": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evChargingVoltageMilliVolt": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evConsumedEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evDistanceDrivenMeters": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evRegeneratedEnergyMicroWh": {
                        "time": "time",
                        "value": 1000000
                      },
                      "evStateOfChargeMilliPercent": {
                        "time": "time",
                        "value": 1000000
                      },
                      "faultCodes": {
                        "canBusType": "canBusType",
                        "j1939": {},
                        "obdii": {},
                        "oem": {}
                      },
                      "fuelConsumedMilliliters": {
                        "value": 1000000
                      },
                      "fuelPercents": {
                        "value": 1000000
                      },
                      "gps": {
                        "address": {},
                        "headingDegrees": 1.1,
                        "isEcuSpeed": true,
                        "latitude": 1.1,
                        "longitude": 1.1,
                        "reverseGeo": {},
                        "speedMilesPerHour": 1.1
                      },
                      "gpsDistanceMeters": {
                        "value": 1.1
                      },
                      "gpsOdometerMeters": {
                        "value": 1000000
                      },
                      "idlingDurationMilliseconds": {
                        "value": 1000000
                      },
                      "intakeManifoldTemperatureMilliC": {
                        "value": 1000000
                      },
                      "obdEngineSeconds": {
                        "value": 1000000
                      },
                      "obdOdometerMeters": {
                        "value": 1000000
                      },
                      "seatbeltDriver": {
                        "time": "time",
                        "value": "Buckled"
                      },
                      "spreaderActive": {
                        "time": "time",
                        "value": "Off"
                      },
                      "spreaderAirTemp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderBlastState": {
                        "time": "time",
                        "value": "On"
                      },
                      "spreaderGranularName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderGranularRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderLiquidName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderLiquidRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderOnState": {
                        "time": "time",
                        "value": "On"
                      },
                      "spreaderPlowStatus": {
                        "time": "time",
                        "value": "Up"
                      },
                      "spreaderPrewetName": {
                        "time": "time",
                        "value": "value"
                      },
                      "spreaderPrewetRate": {
                        "time": "time",
                        "value": 1000000
                      },
                      "spreaderRoadTemp": {
                        "time": "time",
                        "value": 1000000
                      },
                      "tirePressure": {
                        "backLeftTirePressureKPa": 1000000,
                        "backRightTirePressureKPa": 1000000,
                        "frontLeftTirePressureKPa": 1000000,
                        "frontRightTirePressureKPa": 1000000
                      }
                    },
                    "time": "time",
                    "value": 1000000
                  }
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/vehicles/stats")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.VehicleStats.GetVehicleStatsAsync(new GetVehicleStatsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
