namespace CarStore.Domain.Models
{
    internal abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
    }
}
