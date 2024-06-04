namespace FlightReservationApp.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Airport { get; set; }
        public bool Situation { get; set; }
    }
}
