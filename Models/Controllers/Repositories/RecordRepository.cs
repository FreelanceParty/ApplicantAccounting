using Microsoft.EntityFrameworkCore;

namespace ApplicantAccounting.Models.Controllers.Repositories;

public class RecordRepository(DbContext context)
{
    private readonly DbSet<Record> _dbSet = context.Set<Record>();

    public List<Record> GetAll()
    {
        return _dbSet.ToList();
    }
}