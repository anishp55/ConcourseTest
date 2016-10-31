using Xunit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ConcourseTest.UnitTests 
{
    public class TestControllerTests
    {
        [Fact]
        public void ShoudBe1() {
            Assert.Equal(1, 1);
        }        
    }
}