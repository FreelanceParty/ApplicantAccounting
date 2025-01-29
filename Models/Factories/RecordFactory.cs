using ApplicantAccounting.Exceptions;
using ApplicantAccounting.ValueObjects;

namespace ApplicantAccounting.Models.Factories;

public class RecordFactory
{
    public static Record Create(
        string lastName,
        string firstName,
        string middleName,
        int genderTypeId,
        int localityTypeId,
        string address,
        string passportNumber,
        string idCode,
        string registrationCertificate,
        int educationTypeId,
        bool withDormitory,
        bool withCourses,
        bool withBenefits
    )
    {
        var newRecord = new Record()
        {
            LastName = lastName,
            FirstName = firstName,
            MiddleName = middleName,
            GenderTypeId = genderTypeId,
            LocalityTypeId = localityTypeId,
            Address = address,
            PassportNumber = passportNumber,
            IdCode = idCode,
            RegistrationСertificate = registrationCertificate,
            EducationTypeId = educationTypeId,
            Dormitory = withDormitory,
            Courses = withCourses,
            Benefits = withBenefits,
        };
        using var context = new AppDbContext();
        var record = context.Records.FirstOrDefault(r =>
            r.FirstName == newRecord.FirstName &&
            r.LastName == newRecord.LastName &&
            r.MiddleName == newRecord.MiddleName &&
            r.GenderTypeId == newRecord.GenderTypeId &&
            r.LocalityTypeId == newRecord.LocalityTypeId &&
            r.Address == newRecord.Address &&
            r.PassportNumber == newRecord.PassportNumber &&
            r.IdCode == newRecord.IdCode &&
            r.RegistrationСertificate == newRecord.RegistrationСertificate &&
            r.EducationTypeId == newRecord.EducationTypeId &&
            r.Dormitory == newRecord.Dormitory &&
            r.Courses == newRecord.Courses &&
            r.Benefits == newRecord.Benefits
        );
        if (record != null)
        {
            throw new RecordAlreadyExistsException();
        }

        context.Records.Add(newRecord);
        context.SaveChanges();

        return newRecord;
    }
}