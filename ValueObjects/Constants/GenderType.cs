namespace ApplicantAccounting.ValueObjects.Constants;

public static class GenderType
{
    public const int Male = 0;
    public const int Female = 1;

    public static Dictionary<int, string> GetAll()
    {
        return new Dictionary<int, string>()
        {
            { Male, "Чоловік" },
            { Female, "Жінка" },
        };
    }
}