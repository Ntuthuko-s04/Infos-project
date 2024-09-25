public class Booking
{
    private Hotel hotel;
    private Guest mainGuest;
    // are we gonna enum the adults and children idk????????
    //should this be a Collection of guests

    private List<Guest> additionalGuests;
    private Room room;

    private string creditCardInfo;

    private string bookingID;

    public Booking(Hotel hotel, Guest mainGuest, Room room, string creditCardInfo, string bookingID)
    {
        this.hotel = hotel;
        this.mainGuest = mainGuest;
        this.room = room;
        this.creditCardInfo = creditCardInfo;
        this.bookingID = bookingID;
        this.additionalGuests = new List<Guest>();
    }

    public Hotel Hotel
    {
        get { return hotel; }
        set { hotel = value; }
    }

    public Guest MainGuest
    {
        get { return mainGuest; }
        set { mainGuest = value; }
    }

    public List<Guest> AdditionalGuests
    {
        get { return additionalGuests; }
    }

    public Room Room
    {
        get { return room; }
        set { room = value; }
    }

    public string CreditCardInfo
    {
        get { return creditCardInfo; }
        set { creditCardInfo = value; }
    }

    public string BookingID
    {
        get { return bookingID; }
        set { bookingID = value; }
    }

    public void AddAdditionalGuest(Guest guest)
    {
        additionalGuests.Add(guest);
    }
}