namespace FlightReservationApp
{
    public class CreateLocation
    {
        public string Country;
        public string City;
        public string Airport;
        public CreateLocation(string country, string city, string airport)
        {
            Country = country;
            City = city;
            Airport = airport;
        }
    }
}
