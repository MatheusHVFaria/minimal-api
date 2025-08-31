using MinimalAPI.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Domain.Entitys
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            //Arrange
            Veiculo veiculoTest = new Veiculo();

            //Act
            veiculoTest.Id = 1;
            veiculoTest.Nome = "Fusca 1992";
            veiculoTest.Marca = "Wolkswagem";
            veiculoTest.Ano = 1992;

            //Assert
            Assert.AreEqual(1, veiculoTest.Id);
            Assert.AreEqual("Fusca 1992", veiculoTest.Nome);
            Assert.AreEqual("Wolkswagem", veiculoTest.Marca);
            Assert.AreEqual(1992, veiculoTest.Ano);
        }
    }
}
