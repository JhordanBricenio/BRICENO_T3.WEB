using APELLIDO_T3.WEB.Controllers;
using APELLIDO_T3.WEB.Models;
using APELLIDO_T3.WEB.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APELLIDO_T3.TEST.Controller
{
    public class HomeControllerTest
    {

        [Test]
        public void IndexTest01()
        {
            var mockHistoria = new Mock<IHistoriaRepositorio>();
            mockHistoria.Setup(o => o.ObtenerTodos()).Returns(new List<HistoriaClinica>());

            var controller = new HomeController(mockHistoria.Object);
            var result = (ViewResult)controller.Index();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);//Modelo  enviado hacia la vsita no es nulo

        }
        [Test]
        public void CreatePostTest01()
        {
            var mockHistoria = new Mock<IHistoriaRepositorio>();
                //mockHistoria.Setup(o => o.ObtenerTodos()).Returns(new List<HistoriaClinica>());
            var httpContext = new DefaultHttpContext();
            var tempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
            tempData["SuccessMessage"] = "admin";
            

            var controller = new HomeController(mockHistoria.Object)
            {
                TempData = tempData
            }; 

            var result = controller.Create(new HistoriaClinica() { Id = 1, NombreDueno = "Ingenieria" });
            Assert.IsNotNull(result);

        }
    }
}
