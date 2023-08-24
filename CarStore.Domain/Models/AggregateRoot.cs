namespace CarStore.Domain.Models
{
    public class AggregateRoot<T> : Entity<T> where T : notnull
    {
        protected AggregateRoot(T id) : base(id) { }
    }
}
