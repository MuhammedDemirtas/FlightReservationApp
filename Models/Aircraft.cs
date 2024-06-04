namespace FlightReservationApp.Models
{
    public partial class Aircraft
    {
        public int AircraftId { get; set; }
        public string? AircraftModel { get; set; }
        public string? ACTrademark { get; set; }
        public string? ACSerialNumber { get; set; }
        public int ACSeatCapacity { get; set; }
    }
}
