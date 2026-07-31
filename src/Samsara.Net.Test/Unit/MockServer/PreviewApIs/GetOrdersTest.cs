using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class GetOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "customerProperties": [
                    {
                      "key": "key",
                      "value": "value"
                    },
                    {
                      "key": "key",
                      "value": "value"
                    }
                  ],
                  "externalIds": {},
                  "id": "id",
                  "samsaraCustomerOrderName": "samsaraCustomerOrderName",
                  "tasks": [
                    {
                      "createdAtTime": "2024-01-15T09:30:00.000Z",
                      "customerProperties": [
                        {
                          "key": "key",
                          "value": "value"
                        },
                        {
                          "key": "key",
                          "value": "value"
                        }
                      ],
                      "dispatcherNotes": "dispatcherNotes",
                      "driverNotes": "driverNotes",
                      "hubId": "hubId",
                      "id": "id",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        },
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        }
                      ],
                      "routeId": "routeId",
                      "serviceDurationSeconds": 1000000,
                      "serviceLocation": {
                        "addressId": "addressId",
                        "customAddress": {
                          "addressLine1": "addressLine1",
                          "addressLine2": "addressLine2",
                          "city": "city",
                          "country": "country",
                          "formattedAddress": "formattedAddress",
                          "latitude": 1.1,
                          "longitude": 1.1,
                          "postalCode": "postalCode",
                          "state": "state"
                        },
                        "serviceLocationType": "unknown"
                      },
                      "serviceWindows": [
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        },
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "createdAtTime": "2024-01-15T09:30:00.000Z",
                      "customerProperties": [
                        {
                          "key": "key",
                          "value": "value"
                        },
                        {
                          "key": "key",
                          "value": "value"
                        }
                      ],
                      "dispatcherNotes": "dispatcherNotes",
                      "driverNotes": "driverNotes",
                      "hubId": "hubId",
                      "id": "id",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        },
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        }
                      ],
                      "routeId": "routeId",
                      "serviceDurationSeconds": 1000000,
                      "serviceLocation": {
                        "addressId": "addressId",
                        "customAddress": {
                          "addressLine1": "addressLine1",
                          "addressLine2": "addressLine2",
                          "city": "city",
                          "country": "country",
                          "formattedAddress": "formattedAddress",
                          "latitude": 1.1,
                          "longitude": 1.1,
                          "postalCode": "postalCode",
                          "state": "state"
                        },
                        "serviceLocationType": "unknown"
                      },
                      "serviceWindows": [
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        },
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                },
                {
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "customerProperties": [
                    {
                      "key": "key",
                      "value": "value"
                    },
                    {
                      "key": "key",
                      "value": "value"
                    }
                  ],
                  "externalIds": {},
                  "id": "id",
                  "samsaraCustomerOrderName": "samsaraCustomerOrderName",
                  "tasks": [
                    {
                      "createdAtTime": "2024-01-15T09:30:00.000Z",
                      "customerProperties": [
                        {
                          "key": "key",
                          "value": "value"
                        },
                        {
                          "key": "key",
                          "value": "value"
                        }
                      ],
                      "dispatcherNotes": "dispatcherNotes",
                      "driverNotes": "driverNotes",
                      "hubId": "hubId",
                      "id": "id",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        },
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        }
                      ],
                      "routeId": "routeId",
                      "serviceDurationSeconds": 1000000,
                      "serviceLocation": {
                        "addressId": "addressId",
                        "customAddress": {
                          "addressLine1": "addressLine1",
                          "addressLine2": "addressLine2",
                          "city": "city",
                          "country": "country",
                          "formattedAddress": "formattedAddress",
                          "latitude": 1.1,
                          "longitude": 1.1,
                          "postalCode": "postalCode",
                          "state": "state"
                        },
                        "serviceLocationType": "unknown"
                      },
                      "serviceWindows": [
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        },
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "createdAtTime": "2024-01-15T09:30:00.000Z",
                      "customerProperties": [
                        {
                          "key": "key",
                          "value": "value"
                        },
                        {
                          "key": "key",
                          "value": "value"
                        }
                      ],
                      "dispatcherNotes": "dispatcherNotes",
                      "driverNotes": "driverNotes",
                      "hubId": "hubId",
                      "id": "id",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        },
                        {
                          "capacityId": "capacityId",
                          "id": "id",
                          "label": "label",
                          "value": 1.1
                        }
                      ],
                      "routeId": "routeId",
                      "serviceDurationSeconds": 1000000,
                      "serviceLocation": {
                        "addressId": "addressId",
                        "customAddress": {
                          "addressLine1": "addressLine1",
                          "addressLine2": "addressLine2",
                          "city": "city",
                          "country": "country",
                          "formattedAddress": "formattedAddress",
                          "latitude": 1.1,
                          "longitude": 1.1,
                          "postalCode": "postalCode",
                          "state": "state"
                        },
                        "serviceLocationType": "unknown"
                      },
                      "serviceWindows": [
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        },
                        {
                          "endTime": "2024-01-15T09:30:00.000Z",
                          "id": "id",
                          "startTime": "2024-01-15T09:30:00.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/orders")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.GetOrdersAsync(new GetOrdersRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
