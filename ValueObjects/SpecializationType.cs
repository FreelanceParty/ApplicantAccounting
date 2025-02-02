namespace ApplicantAccounting.ValueObjects;

public static class SpecializationType
{
    public const int KI = 0;
    public const int MT = 1;
    public const int MG = 2;
    public const int GRS = 3;
    public const int PTB = 4;
    public const int FB = 5;

    public static Dictionary<int, string> GetAll()
    {
        return new Dictionary<int, string>()
        {
            { KI, "КІ" },
            { MT, "МТ" },
            { MG, "МГ" },
            { GRS, "ГРС" },
            { PTB, "ПТБ" },
            { FB, "ФБ" },
        };
    }
}