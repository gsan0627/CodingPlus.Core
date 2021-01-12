﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPlus.Core.Abstractions
{
    /// <summary>
    /// Definicion para las entidades del patron repositorio
    /// </summary>
    /// <typeparam name="TUserKey">Tipo que identificara el usuario</typeparam>
    interface IEntityLong<TUserKey> : IDtoBase<long, TUserKey>
    {
    }
}
