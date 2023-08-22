using CarStore.Domain.Models.ValueObjects.Car;

namespace CarStore.Domain.Models.Aggregates
{
    internal sealed class Car : AggregateRoot<Car>
    {
        public CarModel CarModel { get; init; }
        public EngineDetail EngineDetail { get; init; }
        public Equipment Equipment { get; init; }
        public InspectionStatus InspectionStatus { get; init; }
        public InsuranceStatus InsuranceStatus { get; init; }
        public ProductionDate ProductionDate { get; init; }
        public Tuning Tuning { get; init; }
        public VIN VIN { get; init; }
        public DamageHistory DamageHistory { get; init; }
        public DamageStatus DamageStatus { get; init; }
        public OriginCountry OriginCountry { get; set; }

        public Car(CarModel carModel, EngineDetail engineDetail, Equipment equipment, InspectionStatus inspectionStatus, InsuranceStatus insuranceStatus, ProductionDate productionDate, Tuning tuning, VIN vIN, DamageHistory damageHistory, DamageStatus damageStatus, OriginCountry originCountry)
        {
            CarModel = carModel;
            EngineDetail = engineDetail;
            Equipment = equipment;
            InspectionStatus = inspectionStatus;
            InsuranceStatus = insuranceStatus;
            ProductionDate = productionDate;
            Tuning = tuning;
            VIN = vIN;
            DamageHistory = damageHistory;
            DamageStatus = damageStatus;
            OriginCountry = originCountry;
        }
    }
}
