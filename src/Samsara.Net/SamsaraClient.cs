using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.Assets;
using Samsara.Net.AuthTokenForDriver;
using Samsara.Net.BetaApIs;
using Samsara.Net.CarrierProposedAssignments;
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
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token ?? ""}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Samsara.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Samsara.Net/5.5.0" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Addresses = new AddressesClient(_client);
        Alerts = new AlertsClient(_client);
        Assets = new AssetsClient(_client);
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
        CarrierProposedAssignments = new CarrierProposedAssignmentsClient(_client);
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

    public AddressesClient Addresses { get; }

    public AlertsClient Alerts { get; }

    public AssetsClient Assets { get; }

    public BetaApIsClient BetaApIs { get; }

    public LocationAndSpeedClient LocationAndSpeed { get; }

    public Samsara.Net.Attributes.AttributesClient Attributes { get; }

    public MediaClient Media { get; }

    public CoachingClient Coaching { get; }

    public ContactsClient Contacts { get; }

    public MaintenanceClient Maintenance { get; }

    public FuelAndEnergyClient FuelAndEnergy { get; }

    public DriverTrailerAssignmentsClient DriverTrailerAssignments { get; }

    public DriverQrCodesClient DriverQrCodes { get; }

    public CarrierProposedAssignmentsClient CarrierProposedAssignments { get; }

    public LegacyApIsClient LegacyApIs { get; }

    public DocumentsClient Documents { get; }

    public DriverVehicleAssignmentsClient DriverVehicleAssignments { get; }

    public DriversClient Drivers { get; }

    public AuthTokenForDriverClient AuthTokenForDriver { get; }

    public TachographEuOnlyClient TachographEuOnly { get; }

    public EquipmentClient Equipment { get; }

    public HoursOfServiceClient HoursOfService { get; }

    public IftaClient Ifta { get; }

    public RoutesClient Routes { get; }

    public SettingsClient Settings { get; }

    public TrailersClient Trailers { get; }

    public VehiclesClient Vehicles { get; }

    public VehicleLocationsClient VehicleLocations { get; }

    public VehicleStatsClient VehicleStats { get; }

    public FormsClient Forms { get; }

    public GatewaysClient Gateways { get; }

    public HubsClient Hubs { get; }

    public PlansClient Plans { get; }

    public IdlingClient Idling { get; }

    public IndustrialClient Industrial { get; }

    public IssuesClient Issues { get; }

    public LiveSharingLinksClient LiveSharingLinks { get; }

    public WorkOrdersClient WorkOrders { get; }

    public OrganizationInfoClient OrganizationInfo { get; }

    public PreviewApIsClient PreviewApIs { get; }

    public RouteEventsClient RouteEvents { get; }

    public SafetyClient Safety { get; }

    public SpeedingIntervalsClient SpeedingIntervals { get; }

    public TagsClient Tags { get; }

    public TrainingAssignmentsClient TrainingAssignments { get; }

    public TrainingCoursesClient TrainingCourses { get; }

    public TripsClient Trips { get; }

    public UsersClient Users { get; }

    public LegacyClient Legacy { get; }

    public MessagesClient Messages { get; }

    public TrailerAssignmentsClient TrailerAssignments { get; }

    public SensorsClient Sensors { get; }

    public WebhooksClient Webhooks { get; }

    public FleetClient Fleet { get; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
