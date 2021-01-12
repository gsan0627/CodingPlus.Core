using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodingPlus.Core.Models.Pager
{
    /// <summary>
    /// Modelo que permita obtener los datos de la peticion para paginar lo datos
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// PAgina actual
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "The {0} field not is valid")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Numero de registro en la pagina
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "The {0} field not is valid")]
        public int PageSize { get; set; }

        /// <summary>
        /// Numero de pagina maximas
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "The {0} field not is valid")]
        public int MaxPage { get; set; }
    }
}
