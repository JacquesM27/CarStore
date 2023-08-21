namespace CarStore.Domain.Models
{
    internal sealed class Entity : IEquatable<Entity>
    {
        public string Id { get; }

        public Entity(string id) => Id = id;

        public bool Equals(Entity? other)
        {
            if (other is null) return false;
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }

        public override bool Equals(object? obj)
        {
            if(obj is null) return false;
            if(ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Entity)obj);
        }

        public override int GetHashCode() => Id.GetHashCode();

        public static implicit operator Entity(string id) => new(id);

        public static implicit operator string(Entity entity) => entity.Id;
    }
}
