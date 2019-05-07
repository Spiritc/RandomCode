using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
