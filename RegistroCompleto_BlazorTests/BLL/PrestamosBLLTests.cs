using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroCompleto_Blazor.BLL;
using RegistroCompleto_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCompleto_Blazor.BLL.Tests
{

    [TestClass()]
    public class PrestamosBLLTests
    {
        private Prestamos prestamo = new Prestamos()
        {
            PrestamoId = 1,
            PersonaId = 1,
            Fecha = DateTime.Now,
            Concepto = "Pago de universidad",
            Monto = 1000,
            Balance = 1000
        };

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = PrestamosBLL.Guardar(prestamo);

            Assert.IsTrue(paso, "Error al guardar");
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = PrestamosBLL.Modificar(prestamo);

            Assert.IsTrue(paso, "Error al modificar");
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = PrestamosBLL.Buscar(prestamo.PrestamoId);

            Assert.IsNotNull(encontrado, "No encontrado");
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = PrestamosBLL.Existe(prestamo.PrestamoId);

            Assert.IsTrue(paso, "Existe");
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listaPrestamos = PrestamosBLL.GetPrestamo();

            Assert.IsNotNull(listaPrestamos, "Error al obtener lista");
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = PrestamosBLL.Eliminar(prestamo.PersonaId);

            Assert.IsTrue(paso, "Error al eliminar");
        }

    }

}