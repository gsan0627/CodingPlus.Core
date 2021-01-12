using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPlus.Core.Abstractions
{
    /// <summary>
    /// Especificación del contrato para la administración de servicios personalizados en el SDK CodeDesignPlus
    /// </summary>
    public interface IStartupService
    {
        /// <summary>
        /// Este metodo es invocado por el SDK CodingPlus en el moento de iniciar la aplicacion para registrar servicios personalizados
        /// </summary>
        /// <param name="services">Provee acceso de contenedor de dependencias de .net core</param>
        /// <param name="configuration">Provee acceso a las diferentes fuentes de configuracion</param>
        void Initialize(IServiceCollection services, IConfiguration configuration);
    }
}
