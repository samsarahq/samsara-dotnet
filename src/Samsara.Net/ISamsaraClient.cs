using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.AuthTokenForDriver;
using Samsara.Net.BetaApIs;
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

public partial interface ISamsaraClient
{
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
}
