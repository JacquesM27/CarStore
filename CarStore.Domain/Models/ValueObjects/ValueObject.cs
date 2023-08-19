namespace CarStore.Domain.Models.ValueObjects
{
    internal abstract class ValueObject<T> : IEquatable<T> where T : ValueObject<T>
    {
        protected abstract IEnumerable<object> GetAllProperties();
        
        public override int GetHashCode() => GetAllProperties().Aggregate(default(int), HashCode.Combine);

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((T)obj);
        }

        public bool Equals(T? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return GetAllProperties().SequenceEqual(other.GetAllProperties());
        }
    }
}
