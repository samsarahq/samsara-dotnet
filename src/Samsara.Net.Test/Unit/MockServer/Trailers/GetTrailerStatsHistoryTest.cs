using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Trailers;

namespace Samsara.Net.Test.Unit.MockServer.Trailers;

[TestFixture]
public class GetTrailerStatsHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "carrierReeferState": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "substateValue": "`Pretrip`, `Defrost`",
                      "time": "2020-01-27T07:06:25Z",
                      "value": "`Off`, `On`"
                    }
                  ],
                  "externalIds": {
                    "key": "value"
                  },
                  "gps": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "headingDegrees": 1495749085005925000,
                      "latitude": 0.5449429145346,
                      "longitude": 0.46982365750308985,
                      "reverseGeo": {
                        "formattedLocation": "850 Made Up Lane, Orange, CA"
                      },
                      "speedMilesPerHour": 152047843600549300,
                      "time": "2020-01-27T07:06:25Z"
                    }
                  ],
                  "gpsOdometerMeters": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "id": "1234",
                  "name": "Trailer-123",
                  "reeferAlarms": [
                    {
                      "alarms": [
                        {
                          "alarmCode": "3",
                          "description": "Test alarm",
                          "operatorAction": "Manually disable alarm",
                          "severity": 6264683518707844000
                        }
                      ],
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z"
                    }
                  ],
                  "reeferAmbientAirTemperatureMilliC": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferDoorStateZone1": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": "open"
                    }
                  ],
                  "reeferDoorStateZone2": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": "open"
                    }
                  ],
                  "reeferDoorStateZone3": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": "open"
                    }
                  ],
                  "reeferFuelPercent": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferObdEngineSeconds": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferReturnAirTemperatureMilliCZone1": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferReturnAirTemperatureMilliCZone2": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferReturnAirTemperatureMilliCZone3": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferRunMode": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": "`Start/Stop`,`Continuous`"
                    }
                  ],
                  "reeferSetPointTemperatureMilliCZone1": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferSetPointTemperatureMilliCZone2": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferSetPointTemperatureMilliCZone3": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferStateZone1": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "substateValue": "`Pretrip`, `Defrost`",
                      "time": "2020-01-27T07:06:25Z",
                      "value": "`Off`, `On`"
                    }
                  ],
                  "reeferStateZone2": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "substateValue": "`Pretrip`, `Defrost`",
                      "time": "2020-01-27T07:06:25Z",
                      "value": "`Off`, `On`"
                    }
                  ],
                  "reeferStateZone3": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "substateValue": "`Pretrip`, `Defrost`",
                      "time": "2020-01-27T07:06:25Z",
                      "value": "`Off`, `On`"
                    }
                  ],
                  "reeferSupplyAirTemperatureMilliCZone1": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferSupplyAirTemperatureMilliCZone2": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ],
                  "reeferSupplyAirTemperatureMilliCZone3": [
                    {
                      "decorations": {
                        "carrierReeferState": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "gps": {
                          "headingDegrees": 7982033236946874000,
                          "latitude": 0.02659130816226228,
                          "longitude": 0.468774774626828,
                          "reverseGeo": {
                            "formattedLocation": "850 Made Up Lane, Orange, CA"
                          },
                          "speedMilesPerHour": 842599652113183900,
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "gpsOdometerMeters": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferAlarms": {
                          "alarms": [
                            {
                              "alarmCode": "3",
                              "description": "Test alarm",
                              "operatorAction": "Manually disable alarm",
                              "severity": 6264683518707844000
                            }
                          ],
                          "time": "2020-01-27T07:06:25Z"
                        },
                        "reeferAmbientAirTemperatureMilliC": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferDoorStateZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferDoorStateZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "open"
                        },
                        "reeferFuelPercent": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferObdEngineSeconds": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferReturnAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferRunMode": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Start/Stop`,`Continuous`"
                        },
                        "reeferSetPointTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSetPointTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferStateZone1": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone2": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferStateZone3": {
                          "substateValue": "`Pretrip`, `Defrost`",
                          "time": "2020-01-27T07:06:25Z",
                          "value": "`Off`, `On`"
                        },
                        "reeferSupplyAirTemperatureMilliCZone1": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone2": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        },
                        "reeferSupplyAirTemperatureMilliCZone3": {
                          "time": "2020-01-27T07:06:25Z",
                          "value": 50
                        }
                      },
                      "time": "2020-01-27T07:06:25Z",
                      "value": 50
                    }
                  ]
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/trailers/stats/history")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .WithParam("types", "types")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trailers.GetTrailerStatsHistoryAsync(
            new GetTrailerStatsHistoryRequest
            {
                StartTime = "startTime",
                EndTime = "endTime",
                Types = "types",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
