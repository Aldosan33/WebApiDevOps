using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiDevOps.Controllers;
using Xunit;

namespace WebApiDevOps.Test
{
    public class ValuesControllerTest
    {
        ValuesController _controller;
        public ValuesControllerTest()
        {
            _controller = new ValuesController();
        }

        [Fact]
        public void Test_Get_Values()
        {
            //Arrange
            string[] expected = new string[] { "value1", "value2", "value3" };

            // Act
            var result = _controller.Get();

            // Assert
            Assert.Equal(expected, result.Value);
        }
    }
}
