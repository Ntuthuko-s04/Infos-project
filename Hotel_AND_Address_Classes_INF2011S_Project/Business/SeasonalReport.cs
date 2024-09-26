public class seasonalReport
{

    
    private Hotel hotel
    private DateTime startDate;
    private DateTime endDate;
    private DateTime dateGenerated;

    private int numberOfGuest;
    private int averageStay;

    private int totalBookings;

    private decimal totalRevenue;

    private double cancellationRate;

    private int numberOfCancellations;

     public SeasonalReport(Hotel hotel, DateTime startDate, DateTime endDate)
    {
        this.hotel = hotel;
        this.startDate = startDate;
        this.endDate = endDate;
        this.dateGenerated = DateTime.Now; 
        this.numberOfGuests = 0;
        this.averageStay = 0;
        this.totalBookings = 0;
        this.totalRevenue = 0m;
        this.cancellationRate = 0.0;
        this.numberOfCancellations = 0;
    }

    public Hotel Hotel
    {
        get { return hotel; }
        set { hotel = value; }
    }

    public DateTime StartDate
    {
        get { return startDate; }
        set { startDate = value; }
    }

    public DateTime EndDate
    {
        get { return endDate; }
        set { endDate = value; }
    }

    public DateTime DateGenerated
    {
        get { return dateGenerated; }
    }

    public int NumberOfGuests
    {
        get { return numberOfGuests; }
        set { numberOfGuests = value; }
    }

    public int AverageStay
    {
        get { return averageStay; }
        set { averageStay = value; }
    }

    public int TotalBookings
    {
        get { return totalBookings; }
        set { totalBookings = value; }
    }

    public decimal TotalRevenue
    {
        get { return totalRevenue; }
        set { totalRevenue = value; }
    }

    public double CancellationRate
    {
        get { return cancellationRate; }
        set { cancellationRate = value; }
    }

    public int NumberOfCancellations
    {
        get { return numberOfCancellations; }
        set { numberOfCancellations = value; }
    }

}
