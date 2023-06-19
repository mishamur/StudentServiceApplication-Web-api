using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitStudServiceAppTest
{
    public class TestMicrosoftFunction
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 1, 3)]
        [InlineData(2, 2, 1)]
        public void TestAnyFunction(int value1, int value2, int value3)
        {
            //Arrange
            List<int> list = new List<int> { value1, value2, value3 };
            //Act
            bool shouldBeTrue = list.Any(x => x == 1);
            //Assert
            Assert.True(shouldBeTrue);
        }
    }
}
