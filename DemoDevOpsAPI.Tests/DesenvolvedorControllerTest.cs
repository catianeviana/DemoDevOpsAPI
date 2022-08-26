using DemoDevOpsAPI.Controllers;
using DemoDevOpsAPI.Models;
using DemoDevOpsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevOpsAPI.Tests
{
    public class DesenvolvedorControllerTest
    {
 
        DesenvolvedorController _controller;
        IDesenvolvedorService _service;
        public DesenvolvedorControllerTest()
        {
            _service = new DesenvolvedorServiceFake();
            _controller = new DesenvolvedorController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Desenvolvedor>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }
    }
}
