using Bakery.Models;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Bakery.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTest_Bakery
{
    public class UnitTest1
    {
        private IPieRepository _pieRepository;

        public UnitTest1(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [Fact]
        public void testAllPies()
        {
            //IEnumerable<Pie> pies = _pieRepository.AllPies;
            var pies = _pieRepository.AllPies;
            var PieCount = pies.Count();
                
            Assert.Equal(5, PieCount);
        }


        [Fact]
        public void MyTestOne()
        {
            //testing if the controller returns a ViewResult
            //Arrange  
            var mockData = new Mock<IPieRepository>();

            //Act           
            var pieController = new PieController(mockData.Object);
            var result = pieController.List();

            //Assert            
            Assert.IsType<ViewResult>(result);

        }
    }
}
