using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalAPI.Dominio.Entidades;
using MinimalAPI.Dominio.Servicos;
using MinimalAPI.Infraestrutura.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Domain.Services
{
    [TestClass]
    public class AdministradorServicoTest
    {
        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
            var adm = new Administrador();
            var context = CriarContextoDeTest();

            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Adminstradores");

            //Act
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";

            var adminServico = new AdministradorServico(context);

            adminServico.Incluir(adm);
            var admDoBanco = adminServico.BuscaPorID(adm.Id);

            //Assert
            if (admDoBanco != null)
            {
                Assert.AreEqual(1, admDoBanco.Id);
            }
        }

        private DbContexto CriarContextoDeTest()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "","..", "..","..")) ;

            var builder = new ConfigurationBuilder()
                .SetBasePath(path ?? Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            return new DbContexto(configuration);
        }
    }
}
