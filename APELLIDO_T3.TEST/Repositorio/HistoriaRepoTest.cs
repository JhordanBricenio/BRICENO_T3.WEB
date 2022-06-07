using APELLIDO_T3.Helpers;
using APELLIDO_T3.WEB.DB;
using APELLIDO_T3.WEB.Models;
using APELLIDO_T3.WEB.Repositorio;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APELLIDO_T3.TEST.Repositorio
{
    
    public class HistoriaRepoTest
    {
        private static IQueryable<HistoriaClinica>? data;
        [SetUp]
        public void Setup()
        {
            data = new List<HistoriaClinica>
            {
                new HistoriaClinica { Id = 1, Especie = "Categoria01" },
                new HistoriaClinica { Id = 2, Especie = "Categoria02" },

            }.AsQueryable();
        }
        [Test]
        public void ObtenerTodosTestCaso01()
        {
            var mockBdSetHistoria = new MockDbSet<HistoriaClinica>(data);


            var mockBd = new Mock<DbEntities>();
            mockBd.Setup(x => x.HistoriaClinicas).Returns(mockBdSetHistoria.Object);

            var histoRepo = new HistoriaRepositorio(mockBd.Object);

            var result = histoRepo.ObtenerTodos();

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void GuardarTestCaso01()
        {
            var mockBdSetHistoria = new MockDbSet<HistoriaClinica>(data);


            var mockBd = new Mock<DbEntities>();
            mockBd.Setup(x => x.HistoriaClinicas).Returns(mockBdSetHistoria.Object);

            var histoRepo = new HistoriaRepositorio(mockBd.Object);

             histoRepo.Agregar(new HistoriaClinica());

            
        }


    }
}
