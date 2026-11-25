using System.Globalization;
using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class GetOrdersStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "1991-03-10T05:05:44.000Z",
                  "customerProperties": [
                    {
                      "key": "purchaseOrderNumber",
                      "value": "PO-12345"
                    }
                  ],
                  "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                  "samsaraCustomerOrderName": "Order 12345",
                  "tasks": [
                    {
                      "createdAtTime": "1978-04-10T10:12:48.000Z",
                      "customerProperties": [
                        {
                          "key": "purchaseOrderNumber",
                          "value": "PO-12345"
                        }
                      ],
                      "dispatcherNotes": "Customer requires lift gate",
                      "driverNotes": "Use loading dock 4",
                      "hubId": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                      "id": "12345678",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "label": "pallets",
                          "value": 0.9093771758102452
                        }
                      ],
                      "routeId": "12345678",
                      "serviceDurationSeconds": 5383547431771835000,
                      "serviceLocation": {
                        "addressId": "12345678",
                        "customAddress": {
                          "addressLine1": "123 Main St",
                          "addressLine2": "Dock 4",
                          "city": "Oakland",
                          "country": "US",
                          "formattedAddress": "123 Main St, Oakland, CA 94607",
                          "latitude": 0.17951671081016027,
                          "longitude": 0.7662845147315845,
                          "postalCode": "94607",
                          "state": "CA"
                        },
                        "serviceLocationType": "unknown"
                      },
                      "serviceWindows": [
                        {
                          "endTime": "1985-04-25T22:02:51.000Z",
                          "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "startTime": "1977-05-21T10:40:21.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "1989-01-02T14:22:45.000Z"
                    }
                  ],
                  "updatedAtTime": "1994-05-17T11:50:16.000Z"
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
                    .WithPath("/preview/fleet/orders/stream")
                    .WithParam("startTime", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.GetOrdersStreamAsync(
            new GetOrdersStreamRequest
            {
                StartTime = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
