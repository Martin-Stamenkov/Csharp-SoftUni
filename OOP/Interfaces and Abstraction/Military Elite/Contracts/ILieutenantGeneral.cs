namespace Military_Elite.Contracts
{
    using System.Collections.Generic;

    interface ILieutenantGeneral : IPrivate
    {
        Dictionary<int, IPrivate> Privates { get; }
    }
}
