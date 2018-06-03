using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FindPhone
{
   public partial class AppleResponse
    {
        [JsonProperty("body")]
        public Body Body { get; set; }

        [JsonProperty("head")]
        public Head Head { get; set; }
    }

    public partial class Head
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class Body
    {
        [JsonProperty("availableStoreText")]
        public string AvailableStoreText { get; set; }

        [JsonProperty("availableStoresText")]
        public string AvailableStoresText { get; set; }

        [JsonProperty("noSimilarModelsText")]
        public string NoSimilarModelsText { get; set; }

        [JsonProperty("PickupMessage")]
        public PickupMessage PickupMessage { get; set; }
    }

    public partial class PickupMessage
    {
        [JsonProperty("little")]
        public bool Little { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("notAvailableNearOneStore")]
        public string NotAvailableNearOneStore { get; set; }

        [JsonProperty("notAvailableNearby")]
        public string NotAvailableNearby { get; set; }

        [JsonProperty("overlayInitiatedFromWarmStart")]
        public bool OverlayInitiatedFromWarmStart { get; set; }

        [JsonProperty("productLocatorSpecialHours")]
        public string ProductLocatorSpecialHours { get; set; }

        [JsonProperty("productLocatorSpecialHoursView")]
        public string ProductLocatorSpecialHoursView { get; set; }

        [JsonProperty("recommendedProducts")]
        public object[] RecommendedProducts { get; set; }

        [JsonProperty("stores")]
        public Store[] Stores { get; set; }

        [JsonProperty("storesCount")]
        public string StoresCount { get; set; }

        [JsonProperty("viewMoreHoursLinkText")]
        public string ViewMoreHoursLinkText { get; set; }
    }

    public partial class Store
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("directionsUrl")]
        public string DirectionsUrl { get; set; }

        [JsonProperty("hoursUrl")]
        public string HoursUrl { get; set; }

        [JsonProperty("makeReservationUrl")]
        public string MakeReservationUrl { get; set; }

        [JsonProperty("partsAvailability")]
        public Data PartsAvailability { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reservationUrl")]
        public string ReservationUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("storeDistanceVoText")]
        public string StoreDistanceVoText { get; set; }

        [JsonProperty("storeDistanceWithUnit")]
        public string StoreDistanceWithUnit { get; set; }

        [JsonProperty("storeEmail")]
        public string StoreEmail { get; set; }

        [JsonProperty("storeHours")]
        public StoreHours StoreHours { get; set; }

        [JsonProperty("storeImageUrl")]
        public string StoreImageUrl { get; set; }

        [JsonProperty("storeListNumber")]
        public long StoreListNumber { get; set; }

        [JsonProperty("storeName")]
        public string StoreName { get; set; }

        [JsonProperty("storeNumber")]
        public string StoreNumber { get; set; }

        [JsonProperty("storedistance")]
        public double Storedistance { get; set; }

        [JsonProperty("storelatitude")]
        public double Storelatitude { get; set; }

        [JsonProperty("storelistnumber")]
        public long Storelistnumber { get; set; }

        [JsonProperty("storelongitude")]
        public double Storelongitude { get; set; }
    }

    public partial class StoreHours
    {
        [JsonProperty("bopisPickupDays")]
        public string BopisPickupDays { get; set; }

        [JsonProperty("bopisPickupHours")]
        public string BopisPickupHours { get; set; }

        [JsonProperty("hours")]
        public Hour[] Hours { get; set; }

        [JsonProperty("storeHoursText")]
        public string StoreHoursText { get; set; }
    }

    public partial class Hour
    {
        [JsonProperty("storeDays")]
        public string StoreDays { get; set; }

        [JsonProperty("storeTimings")]
        public string StoreTimings { get; set; }
    }

    public partial class Data
    {
    }

    public partial class Address
    {
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public object Address3 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("address")]
        public string PurpleAddress { get; set; }
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
