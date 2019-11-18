namespace Military_Elite.Contracts
{
    using Enums;

    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
