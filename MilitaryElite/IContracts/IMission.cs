using MilitaryElite.ENums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void CompleteMission();
    }
}
