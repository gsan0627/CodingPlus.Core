using System;
using System.Collections.Generic;
using System.Text;
using CodingPlus.Core.Abstractions;

namespace CodingPlus.Core.Test.Helpers.Context
{
    /// <summary>
    /// Entidad fake que permitira validar el modelo de paginación
    /// </summary>
    public class FakeEntity : IEntityLong<string>
    {
        /// <summary>
        /// Id del registro
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Fake Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Id del usuario que creo el registro
        /// </summary>
        public string IdUserCreation { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime DateCreated { get; set; }        
    }
}
