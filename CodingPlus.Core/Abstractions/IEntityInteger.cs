using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPlus.Core.Abstractions
{
    /// <summary>
    /// Definicion para las entidades del patron repositorio
    /// </summary>
    /// <typeparam name="TUserKey">Tipo que identificara el usuario</typeparam>
    public interface IEntityInteger<TUserKey> : IDtoBase<int, TUserKey>
    {
    }
}
