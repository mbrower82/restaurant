namespace Restaurant.Models
{
    public class Reservation
    {
        public int ReserveId { get; set; }
        public string ReserveName { get; set; }
        public DateTime Date { get; set; }

        public List<MenuItem> MenuItems { get; set; }

       
    }
}
