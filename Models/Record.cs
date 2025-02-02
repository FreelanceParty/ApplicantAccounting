using ApplicantAccounting.ValueObjects;

namespace ApplicantAccounting.Models;

public class Record
{
    public int Id { get; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    // public string BirthdayDate { get; set; }
    public int GenderTypeId { get; set; }
    public string Locality { get; set; }
    public string Address { get; set; }
    public string PassportNumber { get; set; }
    public string IdCode { get; set; }
    public string RegistrationСertificate { get; set; }
    public int EducationTypeId { get; set; }
    public bool Dormitory { get; set; }
    public bool Courses { get; set; }

    public bool Benefits { get; set; }
    // public string SubmissionDate { get; set; }
    public int SpecializationTypeId { get; set; }

    public static Dictionary<string, string> GetColumns()
    {
        return new Dictionary<string, string>()
        {
            { "id", "№" },
            { "lastName", "Прізвище" },
            { "firstName", "Ім'я" },
            { "middleName", "По-батькові" },
            { "gender", "Стать" },
            { "locality", "Населений пункт" },
            { "address", "Адреса" },
            { "passportNumber", "Паспорт №" },
            { "idCode", "IД код" },
            { "regCert", "Приписне" },
            { "education", "Освіта" },
            { "dormitory", "Гуртожиток" },
            { "courses", "Курси" },
            { "benefits", "Пільги" },
            { "specialization", "Спеціальність" },
        };
    }

    public Dictionary<string, string> GetDataForGridRow()
    {
        return new Dictionary<string, string>()
        {
            { "id", Id.ToString() },
            { "lastName", LastName },
            { "firstName", FirstName },
            { "middleName", MiddleName },
            { "gender", GenderType.GetAll()[GenderTypeId] },
            { "locality", Locality },
            { "address", Address },
            { "passportNumber", PassportNumber },
            { "idCode", IdCode },
            { "regCert", RegistrationСertificate },
            { "education", EducationType.GetAll()[EducationTypeId] },
            { "dormitory", Dormitory ? "Так" : "Ні" },
            { "courses", Courses ? "Так" : "Ні" },
            { "benefits", Benefits ? "Так" : "Ні" },
            { "specialization", SpecializationType.GetAll()[SpecializationTypeId] },
        };
    }
}