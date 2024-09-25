public class Report
{
    private Room room;
    private Hotel hotel;
    private Guest guest;
    private string reportID;
    private DateTime checkInDate;
    private DateTime checkOutDate;
    private DateTime dateGenerated;

    public Report(Room room, Hotel hotel, Guest guest, string reportID, DateTime checkInDate, DateTime checkOutDate)
    {
        this.room = room;
        this.hotel = hotel;
        this.guest = guest;
        this.reportID = reportID;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        this.dateGenerated = DateTime; 
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

    public string ReportID
    {
        get { return reportID; }
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
}
