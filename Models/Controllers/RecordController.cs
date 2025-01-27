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
    public static List<Record> GetAll()
    {
        return Instance._repository.GetAll();
    }
}