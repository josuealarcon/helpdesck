using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using V4mvc.Entities;

namespace V4mvc.Tests.Controllers
{
    /// <summary>
    /// Summary description for Utils
    /// </summary>
    [TestClass]
    public class Utils
    {
        public Utils()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void FormatoPlacatest()
        {
            Assert.AreEqual("", V4mvc.Entities.Utils.FormatoPatente(""));
            Assert.AreEqual("AAAAA", V4mvc.Entities.Utils.FormatoPatente("AAAAA"));
            Assert.AreEqual("1223", V4mvc.Entities.Utils.FormatoPatente("1223"));
            Assert.AreEqual("V3P-125", V4mvc.Entities.Utils.FormatoPatente("V3P125"));
            Assert.AreEqual("AAA-125", V4mvc.Entities.Utils.FormatoPatente("AAA125"));
            Assert.AreEqual("AAAA-12", V4mvc.Entities.Utils.FormatoPatente("AAAA12"));
            Assert.AreEqual("AA-1200", V4mvc.Entities.Utils.FormatoPatente("AA1200"));
        }
    }
}
