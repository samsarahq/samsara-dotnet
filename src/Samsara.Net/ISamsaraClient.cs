using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.Assets;
using Samsara.Net.AuthTokenForDriver;
using Samsara.Net.BetaApIs;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Coaching;
using Samsara.Net.Contacts;
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
using Samsara.Net.Trips;
using Samsara.Net.Users;
using Samsara.Net.VehicleLocations;
using Samsara.Net.Vehicles;
using Samsara.Net.VehicleStats;
using Samsara.Net.Webhooks;
using Samsara.Net.WorkOrders;

namespace Samsara.Net;

public partial interface ISamsaraClient
{
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
    public TripsClient Trips { get; }
    public UsersClient Users { get; }
    public LegacyClient Legacy { get; }
    public MessagesClient Messages { get; }
    public TrailerAssignmentsClient TrailerAssignments { get; }
    public SensorsClient Sensors { get; }
    public WebhooksClient Webhooks { get; }
    public FleetClient Fleet { get; }
}
