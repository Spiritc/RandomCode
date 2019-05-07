using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface ISoldier
    {
        string FirstName { get; }
        string LastName { get; }
        int Id { get; }
    }
}
