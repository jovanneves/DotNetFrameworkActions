using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetFrameworkActions.UnitTest
{
    [TestClass]
    public class ValidacaoProjetoUnitTest
    {
        [TestMethod]
        public void EhValido()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void NaoEhValido()
        {
            Assert.IsFalse(false);
        }
    }
}
