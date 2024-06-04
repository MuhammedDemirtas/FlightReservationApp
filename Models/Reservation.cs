namespace FlightReservationApp.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int AircraftId { get; set; }
        public int LocationId { get; set; }
        public DateTime Date { get; set; }
        public string? CustomerIdCard { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }
        public string? CustomerGender { get; set; }
        public int SeatNumber { get; set; }
    }
}
