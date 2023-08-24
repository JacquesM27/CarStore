using CarStore.Domain.Enum;

namespace CarStore.Domain.Models.ValueObjects.SalesOffer
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
