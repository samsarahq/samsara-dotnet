using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.AuthTokenForDriver;
using Samsara.Net.BetaApIs;
using Samsara.Net.Coaching;
using Samsara.Net.Contacts;
using Samsara.Net.Core;
using Samsara.Net.Documents;
using Samsara.Net.DriverQrCodes;
using Samsara.Net.Drivers;
using Samsara.Net.DriverTrailerAssignments;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Equipment;
using Samsara.Net.Fleet;
using Samsara.Net.Forms;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Gateways;
using Samsara.Net.HoursOfService;
using Samsara.Net.Hubs;
using Samsara.Net.Idling;
using Samsara.Net.Ifta;
using Samsara.Net.Industrial;
using Samsara.Net.Issues;
using Samsara.Net.Legacy;
using Samsara.Net.LegacyApIs;
using Samsara.Net.LiveSharingLinks;
using Samsara.Net.LocationAndSpeed;
using Samsara.Net.Maintenance;
using Samsara.Net.Media;
using Samsara.Net.Messages;
using Samsara.Net.OrganizationInfo;
using Samsara.Net.Plans;
using Samsara.Net.PreviewApIs;
using Samsara.Net.RouteEvents;
using Samsara.Net.Routes;
using Samsara.Net.Safety;
using Samsara.Net.Sensors;
using Samsara.Net.Settings;
using Samsara.Net.SpeedingIntervals;
using Samsara.Net.TachographEuOnly;
using Samsara.Net.Tags;
using Samsara.Net.TrailerAssignments;
using Samsara.Net.Trailers;
using Samsara.Net.TrainingAssignments;
using Samsara.Net.TrainingCourses;
using Samsara.Net.Trips;
using Samsara.Net.Users;
using Samsara.Net.VehicleLocations;
using Samsara.Net.Vehicles;
using Samsara.Net.VehicleStats;
using Samsara.Net.Webhooks;
using Samsara.Net.WorkOrders;

namespace Samsara.Net;

public partial class SamsaraClient : ISamsaraClient
{
    private readonly RawClient _client;

    public SamsaraClient(string? token = null, ClientOptions? clientOptions = null)
    {
        token ??= GetFromEnvironmentOrThrow(
            "SAMSARA_API_KEY",
            "Please pass in token or set the environment variable SAMSARA_API_KEY."
        );
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Samsara.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Samsara.Net/5.10.0" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "Authorization", $"Bearer {token ?? ""}" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Addresses = new AddressesClient(_client);
        Alerts = new AlertsClient(_client);
        Assets = new Samsara.Net.Assets.AssetsClient(_client);
        BetaApIs = new BetaApIsClient(_client);
        LocationAndSpeed = new LocationAndSpeedClient(_client);
        Attributes = new Samsara.Net.Attributes.AttributesClient(_client);
        Media = new MediaClient(_client);
        Coaching = new CoachingClient(_client);
        Contacts = new ContactsClient(_client);
        Maintenance = new MaintenanceClient(_client);
        FuelAndEnergy = new FuelAndEnergyClient(_client);
        DriverTrailerAssignments = new DriverTrailerAssignmentsClient(_client);
        DriverQrCodes = new DriverQrCodesClient(_client);
        CarrierProposedAssignments =
            new Samsara.Net.CarrierProposedAssignments.CarrierProposedAssignmentsClient(_client);
        LegacyApIs = new LegacyApIsClient(_client);
        Documents = new DocumentsClient(_client);
        DriverVehicleAssignments = new DriverVehicleAssignmentsClient(_client);
        Drivers = new DriversClient(_client);
        AuthTokenForDriver = new AuthTokenForDriverClient(_client);
        TachographEuOnly = new TachographEuOnlyClient(_client);
        Equipment = new EquipmentClient(_client);
        HoursOfService = new HoursOfServiceClient(_client);
        Ifta = new IftaClient(_client);
        Routes = new RoutesClient(_client);
        Settings = new SettingsClient(_client);
        Trailers = new TrailersClient(_client);
        Vehicles = new VehiclesClient(_client);
        VehicleLocations = new VehicleLocationsClient(_client);
        VehicleStats = new VehicleStatsClient(_client);
        Forms = new FormsClient(_client);
        Gateways = new GatewaysClient(_client);
        Hubs = new HubsClient(_client);
        Plans = new PlansClient(_client);
        Idling = new IdlingClient(_client);
        Industrial = new IndustrialClient(_client);
        Issues = new IssuesClient(_client);
        LiveSharingLinks = new LiveSharingLinksClient(_client);
        WorkOrders = new WorkOrdersClient(_client);
        OrganizationInfo = new OrganizationInfoClient(_client);
        PreviewApIs = new PreviewApIsClient(_client);
        RouteEvents = new RouteEventsClient(_client);
        Safety = new SafetyClient(_client);
        SpeedingIntervals = new SpeedingIntervalsClient(_client);
        Tags = new TagsClient(_client);
        TrainingAssignments = new TrainingAssignmentsClient(_client);
        TrainingCourses = new TrainingCoursesClient(_client);
        Trips = new TripsClient(_client);
        Users = new UsersClient(_client);
        Legacy = new LegacyClient(_client);
        Messages = new MessagesClient(_client);
        TrailerAssignments = new TrailerAssignmentsClient(_client);
        Sensors = new SensorsClient(_client);
        Webhooks = new WebhooksClient(_client);
        Fleet = new FleetClient(_client);
    }

    public IAddressesClient Addresses { get; }

    public IAlertsClient Alerts { get; }

    public Samsara.Net.Assets.IAssetsClient Assets { get; }

    public IBetaApIsClient BetaApIs { get; }

    public ILocationAndSpeedClient LocationAndSpeed { get; }

    public Samsara.Net.Attributes.IAttributesClient Attributes { get; }

    public IMediaClient Media { get; }

    public ICoachingClient Coaching { get; }

    public IContactsClient Contacts { get; }

    public IMaintenanceClient Maintenance { get; }

    public IFuelAndEnergyClient FuelAndEnergy { get; }

    public IDriverTrailerAssignmentsClient DriverTrailerAssignments { get; }

    public IDriverQrCodesClient DriverQrCodes { get; }

    public Samsara.Net.CarrierProposedAssignments.ICarrierProposedAssignmentsClient CarrierProposedAssignments { get; }

    public ILegacyApIsClient LegacyApIs { get; }

    public IDocumentsClient Documents { get; }

    public IDriverVehicleAssignmentsClient DriverVehicleAssignments { get; }

    public IDriversClient Drivers { get; }

    public IAuthTokenForDriverClient AuthTokenForDriver { get; }

    public ITachographEuOnlyClient TachographEuOnly { get; }

    public IEquipmentClient Equipment { get; }

    public IHoursOfServiceClient HoursOfService { get; }

    public IIftaClient Ifta { get; }

    public IRoutesClient Routes { get; }

    public ISettingsClient Settings { get; }

    public ITrailersClient Trailers { get; }

    public IVehiclesClient Vehicles { get; }

    public IVehicleLocationsClient VehicleLocations { get; }

    public IVehicleStatsClient VehicleStats { get; }

    public IFormsClient Forms { get; }

    public IGatewaysClient Gateways { get; }

    public IHubsClient Hubs { get; }

    public IPlansClient Plans { get; }

    public IIdlingClient Idling { get; }

    public IIndustrialClient Industrial { get; }

    public IIssuesClient Issues { get; }

    public ILiveSharingLinksClient LiveSharingLinks { get; }

    public IWorkOrdersClient WorkOrders { get; }

    public IOrganizationInfoClient OrganizationInfo { get; }

    public IPreviewApIsClient PreviewApIs { get; }

    public IRouteEventsClient RouteEvents { get; }

    public ISafetyClient Safety { get; }

    public ISpeedingIntervalsClient SpeedingIntervals { get; }

    public ITagsClient Tags { get; }

    public ITrainingAssignmentsClient TrainingAssignments { get; }

    public ITrainingCoursesClient TrainingCourses { get; }

    public ITripsClient Trips { get; }

    public IUsersClient Users { get; }

    public ILegacyClient Legacy { get; }

    public IMessagesClient Messages { get; }

    public ITrailerAssignmentsClient TrailerAssignments { get; }

    public ISensorsClient Sensors { get; }

    public IWebhooksClient Webhooks { get; }

    public IFleetClient Fleet { get; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
