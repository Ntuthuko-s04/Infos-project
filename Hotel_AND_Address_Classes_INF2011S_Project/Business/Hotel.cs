public class Hotel
{
    private string _name;
    private Address _address;
    private int _totalRooms;
    private List<string> _facilities;
    private (decimal minRate, decimal maxRate) _rateRange;
    private double _occupancyRate;

    public Hotel(string name, Address address, int totalRooms, List<string> facilities, (decimal, decimal) rateRange, double occupancyRate)
    {
        Name = name;
        Address = address;
        TotalRooms = totalRooms;
        Facilities = facilities;
        RateRange = rateRange;
        OccupancyRate = occupancyRate;
    }

    public string Name 
    { 
        get { return _name; } 
        set { _name = value; } 
    }

    public Address Address 
    { 
        get { return _address; } 
        set { _address = value; } 
    }

    public int TotalRooms 
    { 
        get { return _totalRooms; } 
        set 
        { 
            if (value < 0) 
            {
                throw new ArgumentException("Total rooms cannot be negative.");
            }
            _totalRooms = value; 
        } 
    }

    public List<string> Facilities 
    { 
        get { return _facilities; } 
        set { _facilities = value; } 
    }

    public (decimal minRate, decimal maxRate) RateRange 
    { 
        get { return _rateRange; } 
        set 
        { 
            if (value.minRate < 0 || value.maxRate < 0) 
            {
                throw new ArgumentException("Rate range cannot be negative.");
            }
            if (value.minRate > value.maxRate) 
            {
                throw new ArgumentException("Minimum rate cannot exceed maximum rate.");
            }
            _rateRange = value; 
        } 
    }

    public double OccupancyRate 
    { 
        get { return _occupancyRate; } 
        set 
        { 
            if (value < 0 || value > 100) 
            {
                throw new ArgumentException("Occupancy rate must be between 0 and 100.");
            }
            _occupancyRate = value; 
        } 
    }

    public override string ToString()
    {
        return $"Hotel: {Name}\n" +
               $"Address: {Address}\n" +
               $"Total Rooms: {TotalRooms}\n" +
               $"Facilities: {string.Join(", ", Facilities)}\n" +
               $"Rate Range: R{RateRange.minRate} - R{RateRange.maxRate}\n" +
               $"Occupancy Rate: {OccupancyRate}%";
    }
}
