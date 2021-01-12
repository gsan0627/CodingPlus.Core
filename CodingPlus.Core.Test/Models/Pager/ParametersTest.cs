using CodingPlus.Core.Models.Pager;
using CodingPlus.Core.Test.Helpers.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CodingPlus.Core.Test.Models.Pager
{

    /// <summary>
    /// Clase que realiza las pruebas unitarias al objeto <see cref="Parameters"/>
    /// </summary>
    public class ParametersTest
    {
        /// <summary>
        /// Valida los accessors y los data annotations
        /// </summary>
        [Fact]
        public void Properties_AccessorsAndDataAnnotations_IsValid()
        {
            // Arrange
            var currentPage = new Random().Next(1, int.MaxValue);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next(1, int.MaxValue);

            var parameters = new Parameters()
            {
                CurrentPage = currentPage,
                MaxPage = maxPage,
                PageSize = pageSize
            };

            // Act
            var results = parameters.Validate();

            // Assert
            Assert.IsEmpty(results);
            Assert.Equals(currentPage, parameters.CurrentPage);
            Assert.Equals(maxPage, parameters.MaxPage);
            Assert.Equals(pageSize, parameters.PageSize);
        }

        /// <summary>
        /// Valida que se genere el mensaje de error cuando la propiedad current page no es valida
        /// </summary>
        [Fact]
        public void Property_CurrentPageIsInvalid_OneValidationError()
        {
            // Arrange
            var currentPage = new Random().Next((int.MaxValue * -1), 0);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next(1, int.MaxValue);

            var parameters = new Parameters()
            {
                CurrentPage = currentPage,
                MaxPage = maxPage,
                PageSize = pageSize
            };

            // Act
            var results = parameters.Validate();

            // Assert
            Assert.Equals(1, results.Count);
            Assert.Equals("The CurrentPage field not is valid.", results.FirstOrDefault().ErrorMessage);
        }

        /// <summary>
        /// Valida que se genere el mensaje de error cuando la propiedad max page no es valida
        /// </summary>
        [Fact]
        public void Property_MaxPageIsInvalid_OneValidationError()
        {
            // Arrange
            var currentPage = new Random().Next(1, int.MaxValue);
            var maxPage = new Random().Next((int.MaxValue * -1), 0);
            var pageSize = new Random().Next(1, int.MaxValue);

            var parameters = new Parameters()
            {
                CurrentPage = currentPage,
                MaxPage = maxPage,
                PageSize = pageSize
            };

            // Act
            var results = parameters.Validate();

            // Assert
            Assert.Equals(1, results.Count);
            Assert.Equals("The MaxPage field not is valid.", results.FirstOrDefault().ErrorMessage);
        }

        /// <summary>
        /// Valida que se genere el mensaje de error cuando la propiedad page size no es valida
        /// </summary>
        [Fact]
        public void Property_PageSizeIsInvalid_OneValidationError()
        {
            // Arrange
            var currentPage = new Random().Next(1, int.MaxValue);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next((int.MaxValue * -1), 0);

            var parameters = new Parameters()
            {
                CurrentPage = currentPage,
                MaxPage = maxPage,
                PageSize = pageSize
            };

            // Act
            var results = parameters.Validate();

            // Assert
            Assert.Equals(1, results.Count);
            Assert.Equals("The PageSize field not is valid.", results.FirstOrDefault().ErrorMessage);
        }
    }

}

