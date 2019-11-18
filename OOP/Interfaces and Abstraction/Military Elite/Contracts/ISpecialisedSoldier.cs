namespace Military_Elite.Contracts
{
    using Enums;

    public interface ISpecialisedSoldier : IPrivate
    {
      Corps Corps { get; }
    }
}
