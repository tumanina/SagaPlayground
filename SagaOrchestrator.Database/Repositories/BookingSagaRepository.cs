using Microsoft.EntityFrameworkCore;
using SagaOrchestrator.Database.Entities;

namespace SagaOrchestrator.Database.Repositories;

public class BookingSagaRepository(SagaDbContext dbContext) : IBookingSagaRepository
{
    private readonly SagaDbContext _dbContext = dbContext;
    public async Task<BookingSagaEntity> CreateBookingAsync(BookingSagaEntity booking)
    {
        _dbContext.Sagas.Add(booking);

        await _dbContext.SaveChangesAsync();

        return booking;
    }

    public async Task<BookingSagaEntity?> GetBookingSagaAsync(Guid id)
    {
        return await _dbContext.Sagas.FirstOrDefaultAsync(s => s.Id == id);
    }
}
