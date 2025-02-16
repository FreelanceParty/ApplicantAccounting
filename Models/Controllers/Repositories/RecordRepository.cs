using Microsoft.EntityFrameworkCore;

namespace ApplicantAccounting.Models.Controllers.Repositories;

public class RecordRepository(DbContext context)
{
    private readonly DbSet<Record> _dbSet = context.Set<Record>();

    public Record FindById(int id)
    {
        return _dbSet.First(x => x.Id == id);
    }

    public List<Record> GetAll()
    {
        return _dbSet.ToList();
    }

    public List<Record> GetFiltered(Func<Record, bool> predicate)
    {
        return _dbSet.Where(predicate).ToList();
    }

    public int GetCount(bool byToday = false)
    {
        return byToday ? _dbSet.Count(x => x.SubmissionDate.Date == DateTime.Today) : _dbSet.Count();
    }
}