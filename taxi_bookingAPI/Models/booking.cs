namespace taxi_bookingAPI.Models
{
    public class booking
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public TimeOnly Time { get; set; }

        public string? pickUpPoint { get; set; }
        public string? destination { get; set; }

        public decimal latitude { get; set; }
        public decimal longitude { get; set; }


    }
}
