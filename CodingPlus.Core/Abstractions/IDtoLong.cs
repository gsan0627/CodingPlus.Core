using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPlus.Core.Abstractions
{
    /// <summary>
    /// Definicion para los datos transfer object de tipo long
    /// </summary>
    /// <typeparam name="TUserKey">Tipo que identificara el usuario</typeparam>
    interface IDtoLong<TUserKey> : IDtoBase<long, TUserKey>
    {
    }
}
