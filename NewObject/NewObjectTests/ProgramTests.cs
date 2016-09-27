using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewObject.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.IsTrue(NewObject.Program.NewObj() != null);
        }
    }
}