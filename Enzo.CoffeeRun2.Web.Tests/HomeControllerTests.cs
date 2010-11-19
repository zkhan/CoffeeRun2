using System;
using System.Linq;
using System.Text;
using Enzo.CoffeeRun2.Web.Controllers;
using Enzo.CoffeeRun2.Web.Models;
using Enzo.CoffeeRun2.Web.Repositories;
using NUnit.Framework;

namespace Enzo.CoffeeRun2.Web.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void PostToIndexShouldStoreCoffeeRequests()
        {
            var requestRepository = new CoffeeRequestRepository();
            var controller = new HomeController(requestRepository);
            var expectedRequest = new CoffeeRequest();

            controller.Index(expectedRequest);

            
            Assert.That(requestRepository.Contains(expectedRequest));
        }
    }
}
