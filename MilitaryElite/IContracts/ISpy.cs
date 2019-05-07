using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
