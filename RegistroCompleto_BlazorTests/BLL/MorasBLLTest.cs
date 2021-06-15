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
    class MorasBLLTest
    {
        private Moras mora = new Moras()
        {
            MoraId = 1,
            Fecha = DateTime.Now,
            Total = 100,
            Detalle = new List<MorasDetalle> {  new MorasDetalle(1,1,1) }
            


    };

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = MorasBLL.Guardar(mora);

            Assert.IsTrue(paso, "Error al guardar");
        } 

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = MorasBLL.Modificar(mora);

            Assert.IsTrue(paso, "Error al modificar");
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrado = MorasBLL.Buscar(mora.MoraId);

            Assert.IsNotNull(encontrado, "No encontrado");
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = MorasBLL.Existe(mora.MoraId);

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
            bool paso = MorasBLL.Eliminar(mora.MoraId);

            Assert.IsTrue(paso, "Error al eliminar");
        }
    }
}
