﻿namespace CarStore.Domain.Models.Shared.Base
{
    public class Entity<T> : IEquatable<Entity<T>> where T : notnull
    {
        public T Id { get; }

        protected Entity(T id) => Id = id;

        public bool Equals(Entity<T>? other)
        {
            if (other is null) return false;
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Entity<T>)obj);
        }

        public override int GetHashCode() => Id.GetHashCode();

        public static implicit operator Entity<T>(T id) => new(id);

        public static implicit operator T(Entity<T> entity) => entity.Id;
    }
}
