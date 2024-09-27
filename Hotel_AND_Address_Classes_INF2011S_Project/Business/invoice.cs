public class invoice
{
    private Room room;
    private Hotel hotel;
    private Guest guest;
    private string reportID;
    private DateTime checkInDate;
    private DateTime checkOutDate;
    private DateTime dateGenerated;
    private BookingController bookingController;

    public invoice(Room room, Hotel hotel, Guest guest, string reportID, DateTime checkInDate, DateTime checkOutDate, BookingController bookingController)
    {
        this.room = room;
        this.hotel = hotel;
        this.guest = guest;
        this.invoiceID = invoiceID;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        this.dateGenerated = DateTime; 
        this.bookingController = bookingController;
    }
    public Room Room
    {
        get { return room; }
        set { room = value; }
    }

    public Hotel Hotel
    {
        get { return hotel; }
        set { hotel = value; }
    }

    public Guest Guest
    {
        get { return guest; }
        set { guest = value; }
    }

    public string invoiceID
    {
        get { return invoiceID; }
        set { reportID = value; }
    }

    public DateTime CheckInDate
    {
        get { return checkInDate; }
        set { checkInDate = value; }
    }

    public DateTime CheckOutDate
    {
        get { return checkOutDate; }
        set { checkOutDate = value; }
    }

    public DateTime DateGenerated
    {
        get { return dateGenerated; }
        set { dateGenerated = value; }
    }
    #region other
public void Display(string bookingID)
{
       Booking booking =  this.bookingController.Find(bookingID);
        
    if (booking != null)
    {
        Console.WriteLine("Invoice Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Invoice ID: {this.InvoiceID}");
        Console.WriteLine($"Date Generated: {this.DateGenerated}");
        Console.WriteLine();
        
        Console.WriteLine("Booking Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Hotel: {booking.Hotel.Name}");
        Console.WriteLine($"Room: {booking.Room.Number} ({booking.Room.Type})");
        Console.WriteLine($"Main Guest: {booking.MainGuest.Name}");
        Console.WriteLine($"Additional Guests:");
        foreach (var guest in booking.AdditionalGuests)
        {
            Console.WriteLine($"- {guest.Name}");
        }
        Console.WriteLine($"Credit Card Info: {booking.CreditCardInfo}");
        Console.WriteLine($"Booking ID: {booking.BookingID}");
        Console.WriteLine($"Check-in Date: {this.CheckInDate}");
        Console.WriteLine($"Check-out Date: {this.CheckOutDate}");
       
    }
    else
    {
        Console.WriteLine("Booking not found for this invoice.");
    }
}

    

   #endregion
    
}
