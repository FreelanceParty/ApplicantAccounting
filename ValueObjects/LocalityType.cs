namespace ApplicantAccounting.ValueObjects;

public static class LocalityType
{
    public const int City = 0;
    public const int Village = 1;

    public static Dictionary<int, string> GetAll()
    {
        return new Dictionary<int, string>()
        {
            { City, "Місто" },
            { Village, "Село" },
        };
    }
}