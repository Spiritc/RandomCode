using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; }
    }
}
