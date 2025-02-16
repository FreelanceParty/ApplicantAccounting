using ApplicantAccounting.ValueObjects;
using Bogus;

namespace ApplicantAccounting.Models.Seeders;

public class RecordSeeder(AppDbContext context)
{
    public void Seed(int count)
    {
        if (!context.Records.Any())
        {
            var records = CreateMany(count);
            context.Records.AddRange(records);
            context.SaveChanges();
        }
    }

    private static Record Create()
    {
        var faker = new Faker("uk");
        return new Record
        {
            LastName = faker.Name.LastName(),
            FirstName = faker.Name.FirstName(),
            MiddleName = "По-батькові " + faker.Random.Int(0, 50),
            BirthdayDate = faker.Date.Between(DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-15)),
            Address = faker.Address.StreetAddress(),
            GenderTypeId = faker.Random.Int(0, GenderType.GetAll().Count - 1),
            EducationTypeId = faker.Random.Int(0, EducationType.GetAll().Count - 1),
            Locality = faker.Address.City(),
            Benefits = faker.Random.Bool(),
            Courses = faker.Random.Bool(),
            Dormitory = faker.Random.Bool(),
            PassportNumber = faker.Random.String2(6),
            IdCode = faker.Random.String2(6),
            RegistrationСertificate = faker.Random.String2(6),
            SpecializationTypeId = faker.Random.Int(0, SpecializationType.GetAll().Count - 1),
            SubmissionDate = faker.Date.Past(2),
        };
    }

    private static List<Record> CreateMany(int count)
    {
        var list = new List<Record>();
        for (int i = 0; i < count; i++)
        {
            list.Add(Create());
        }

        return list;
    }
}