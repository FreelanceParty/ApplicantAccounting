using ApplicantAccounting.ValueObjects;
using Bogus;

namespace ApplicantAccounting.Models.Seeders;

public class RecordSeeder
{
    private readonly AppDbContext _context;

    public RecordSeeder(AppDbContext context)
    {
        _context = context;
    }

    public void Seed(int count)
    {
        if (!_context.Records.Any())
        {
            var records = CreateMany(count);
            _context.Records.AddRange(records);
            _context.SaveChanges();
        }
    }

    private static Record Create()
    {
        var faker = new Faker("uk");
        return new Record
        {
            LastName = faker.Name.LastName(),
            FirstName = faker.Name.FirstName(),
            MiddleName = "По-батькові",
            Address = faker.Address.StreetAddress(),
            GenderTypeId = faker.Random.Int(0, GenderType.GetAll().Count - 1),
            EducationTypeId = faker.Random.Int(0, EducationType.GetAll().Count - 1),
            LocalityTypeId = faker.Random.Int(0, LocalityType.GetAll().Count - 1),
            Benefits = faker.Random.Bool(),
            Courses = faker.Random.Bool(),
            Dormitory = faker.Random.Bool(),
            PassportNumber = faker.Random.String(6),
            IdCode = faker.Random.String(6),
            RegistrationСertificate = faker.Random.String(6),
            
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