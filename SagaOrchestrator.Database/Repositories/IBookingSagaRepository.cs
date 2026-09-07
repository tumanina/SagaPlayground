using SagaOrchestrator.Database.Entities;

namespace SagaOrchestrator.Database.Repositories;

public interface IBookingSagaRepository
{
    public Task<BookingSagaEntity> CreateBookingAsync(BookingSagaEntity booking);
    public Task<BookingSagaEntity?> GetBookingSagaAsync(Guid id);
}
