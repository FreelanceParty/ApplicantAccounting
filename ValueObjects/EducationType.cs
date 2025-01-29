namespace ApplicantAccounting.ValueObjects;

public static class EducationType
{
    public const int NineClass = 0;
    public const int ElevenClass = 1;
    public const int ProfTech = 2;

    public static Dictionary<int, string> GetAll()
    {
        return new Dictionary<int, string>()
        {
            { NineClass, "9 класів" },
            { ElevenClass, "11 класів" },
            { ProfTech, "Проф-тех" },
        };
    }
}