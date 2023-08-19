using CarStore.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Domain.Models.Aggregates
{
    internal class User : AggregateRoot<Entity>
    {
        public FullName FullName { get; init; }
        public Email Email { get; init; }
    }
}
