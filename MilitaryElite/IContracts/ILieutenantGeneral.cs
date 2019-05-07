using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.IContracts
{
    public interface ILieutenantGeneral : ISoldier
    {
        ICollection<IPrivate> Squad {get;}
    }
}
