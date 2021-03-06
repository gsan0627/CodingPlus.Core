﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPlus.Core.Abstractions
{
    /// <summary>
    /// Definicion para las entidades base y restriccion para tipo genericos
    /// </summary>
    public interface IDtoBase : IBase
    {
    }

    /// <summary>
    /// Definicion para las entidades base
    /// </summary>
    /// <typeparam name="TKey">Tipo de dato que identificara el registro</typeparam>
    /// <typeparam name="TUserKey">Tipo de dato que identifica el usuario</typeparam>
    public interface IDtoBase<TKey, TUserKey> : IBase<TKey, TUserKey>, IDtoBase
    {
    }

}
