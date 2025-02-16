using ApplicantAccounting.Models.Controllers.Repositories;

namespace ApplicantAccounting.Models.Controllers;

public class RecordController(RecordRepository repository)
{
    private static RecordController _instance;
    private readonly RecordRepository _repository = repository;

    public static RecordController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new RecordController(new RecordRepository(new AppDbContext()));
            }

            return _instance;
        }
    }

    public static Record FindById(int id)
    {
        return Instance._repository.FindById(id);
    }

    public static List<Record> GetAll()
    {
        return Instance._repository.GetAll();
    }

    public static List<Record> GetFiltered(Func<Record, bool> predicate)
    {
        return Instance._repository.GetFiltered(predicate);
    }

    public static int GetCount(bool byToday = false)
    {
        return Instance._repository.GetCount(byToday);
    }
}