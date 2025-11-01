

namespace ShowroomManagementSystem.Infrastructure.Persistence
{
    public class DbSet<T>
    {
        internal object AsNoTracking()
        {
            throw new NotImplementedException();
        }

        internal async Task FindAsync(object value, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}