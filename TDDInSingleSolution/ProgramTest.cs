using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInSingleSolution
{

    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void AddTwoNumbers()
        {
            // Arrange
            int a = 10;
            int b = 20;
            // Act
            int res = Program.Add(a, b);
            // Assert
            Assert.AreEqual(30, res);
        }
    }
}
