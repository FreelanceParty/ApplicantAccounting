using ApplicantAccounting.Exceptions;

namespace ApplicantAccounting.Models.Factories;

public class RecordFactory
{
    public static Record Create(
        string lastName,
        string firstName,
        string middleName,
        DateTime birthdayDate,
        int genderTypeId,
        string locality,
        string address,
        string passportNumber,
        string idCode,
        string registrationCertificate,
        int educationTypeId,
        bool withDormitory,
        bool withCourses,
        bool withBenefits,
        int specializationTypeId,
        DateTime submissionDate
    )
    {
        var newRecord = new Record()
        {
            LastName = lastName,
            FirstName = firstName,
            MiddleName = middleName,
            BirthdayDate = birthdayDate,
            GenderTypeId = genderTypeId,
            Locality = locality,
            Address = address,
            PassportNumber = passportNumber,
            IdCode = idCode,
            RegistrationСertificate = registrationCertificate,
            EducationTypeId = educationTypeId,
            Dormitory = withDormitory,
            Courses = withCourses,
            Benefits = withBenefits,
            SpecializationTypeId = specializationTypeId,
            SubmissionDate = submissionDate,
        };
        using var context = new AppDbContext();
        var record = context.Records.FirstOrDefault(r =>
            r.FirstName == newRecord.FirstName &&
            r.LastName == newRecord.LastName &&
            r.MiddleName == newRecord.MiddleName &&
            r.BirthdayDate == newRecord.BirthdayDate &&
            r.GenderTypeId == newRecord.GenderTypeId &&
            r.Locality == newRecord.Locality &&
            r.Address == newRecord.Address &&
            r.PassportNumber == newRecord.PassportNumber &&
            r.IdCode == newRecord.IdCode &&
            r.RegistrationСertificate == newRecord.RegistrationСertificate &&
            r.EducationTypeId == newRecord.EducationTypeId &&
            r.Dormitory == newRecord.Dormitory &&
            r.Courses == newRecord.Courses &&
            r.Benefits == newRecord.Benefits &&
            r.SpecializationTypeId == newRecord.SpecializationTypeId &&
            r.SubmissionDate == newRecord.SubmissionDate
        );
        if (record != null)
        {
            throw new RecordAlreadyExistsException();
        }

        context.Records.Add(newRecord);
        context.SaveChanges();

        return newRecord;
    }

    public static Record Update(
        Record record,
        string lastName,
        string firstName,
        string middleName,
        DateTime birthdayDate,
        int genderTypeId,
        string locality,
        string address,
        string passportNumber,
        string idCode,
        string registrationCertificate,
        int educationTypeId,
        bool withDormitory,
        bool withCourses,
        bool withBenefits,
        int specializationTypeId,
        DateTime? submissionDate = null
    )
    {
        using var context = new AppDbContext();
        record.LastName = lastName;
        record.FirstName = firstName;
        record.MiddleName = middleName;
        record.BirthdayDate = birthdayDate;
        record.GenderTypeId = genderTypeId;
        record.Locality = locality;
        record.Address = address;
        record.PassportNumber = passportNumber;
        record.IdCode = idCode;
        record.RegistrationСertificate = registrationCertificate;
        record.EducationTypeId = educationTypeId;
        record.Dormitory = withDormitory;
        record.Courses = withCourses;
        record.Benefits = withBenefits;
        record.SpecializationTypeId = specializationTypeId;
        if (submissionDate != null)
        {
            record.SubmissionDate = (DateTime)submissionDate;
        }

        context.Records.Update(record);
        return record;
    }
}