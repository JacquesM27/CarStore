using CarStore.Domain.Enum;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public sealed class State : ValueObject<State>
    {
        public OfferState OfferState { get; init; }

        public State(OfferState offerState)
        {
            OfferState = offerState;
        }
        protected override IEnumerable<object> GetAllProperties()
        {
            yield return OfferState;
        }
    }
}
