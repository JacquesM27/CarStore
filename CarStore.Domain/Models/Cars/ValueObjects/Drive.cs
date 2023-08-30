namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Drive
    {
        public DriveType DriveType { get; init; }

        public Drive(DriveType driveType)
        {
            DriveType = driveType;
        }

        public static implicit operator Drive(DriveType driveType) => new Drive(driveType);

        public static implicit operator DriveType(Drive drive) => drive.DriveType;
    }
}
