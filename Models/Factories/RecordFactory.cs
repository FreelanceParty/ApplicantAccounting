using ApplicantAccounting.Exceptions;

namespace ApplicantAccounting.Models.Factories;

public class RecordFactory
{
    public static Record Create(string lastName, string firstName, string middleName)
    {
        var newRecord = new Record()
        {
            LastName = lastName,
            FirstName = firstName,
            MiddleName = middleName,
        };
        using (var context = new AppDbContext())
        {
            var record = context.Records.FirstOrDefault(r =>
                r.FirstName == newRecord.FirstName &&
                r.LastName == newRecord.LastName &&
                r.MiddleName == newRecord.MiddleName
            );
            if (record != null)
            {
                throw new RecordAlreadyExistsException();
            }

            context.Records.Add(newRecord);
            context.SaveChanges();
        }

        return newRecord;
    }
}