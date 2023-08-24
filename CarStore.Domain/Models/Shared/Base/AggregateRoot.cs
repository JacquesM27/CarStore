namespace CarStore.Domain.Models.Shared.Base
{
    public class AggregateRoot<T> : Entity<T> where T : notnull
    {
        protected AggregateRoot(T id) : base(id) { }
    }
}
