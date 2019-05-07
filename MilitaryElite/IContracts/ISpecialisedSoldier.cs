using MilitaryElite.ENums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
