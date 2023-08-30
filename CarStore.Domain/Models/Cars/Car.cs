using CarStore.Domain.Models.Cars.ValueObjects;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars
{
    public sealed class Car<T> : AggregateRoot<T>
        where T : notnull
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
        public OriginCountry OriginCountry { get; init; }
        public Mileage Mileage { get; init; }
        public Gearbox Gearbox { get; init; }
        public Seats Seats { get; init; }
        public Doors Doors { get; init; }
        public Drive Drive { get; init; }

        public Car(T id, CarModel carModel, EngineDetail engineDetail, Equipment equipment, InspectionStatus inspectionStatus, InsuranceStatus insuranceStatus, ProductionDate productionDate, Tuning tuning, VIN vIN, DamageHistory damageHistory, DamageStatus damageStatus, OriginCountry originCountry, Mileage mileage, Gearbox gearbox, Seats seats, Doors doors, Drive drive)
            : base(id)
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
            Mileage = mileage;
            Gearbox = gearbox;
            Seats = seats;
            Doors = doors;
            Drive = drive;
        }
    }
}
