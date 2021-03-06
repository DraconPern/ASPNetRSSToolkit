﻿// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using RssToolkit.Opml;
namespace RssToolkitUnitTest
{
    /// <summary>
    ///This is a test class for RssToolkit.Opml.OutlineInfo and is intended
    ///to contain all RssToolkit.Opml.OutlineInfo Unit Tests
    ///</summary>
    [TestClass()]
    public class OutlineInfoTest
    {
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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Index
        ///</summary>
        [DeploymentItem("RssToolkit.dll")]
        [TestMethod()]
        public void OpmlOutlineInfoIndexTest()
        {
            OpmlOutline ol = new OpmlOutline();
            int index = 10;
            object target = RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor.CreatePrivate(ol, index);
            int val = 10;

            RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor accessor = new RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor(target);
            Assert.AreEqual(val, accessor.Index, "RssToolkit.Opml.OutlineInfo.Index was not set correctly.");
        }

        /// <summary>
        ///A test for Outline
        ///</summary>
        [DeploymentItem("RssToolkit.dll")]
        [TestMethod()]
        public void OpmlOutlineInfoOutlineTest()
        {
            OpmlOutline ol = new OpmlOutline();
            ol.XmlUrl = "http://www.microsoft.com";
            int index = 11;

            object target = RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor.CreatePrivate(ol, index);

            OpmlOutline val = new OpmlOutline();
            val.XmlUrl = "http://www.microsoft.com";
            RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor accessor = new RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor(target);
            Assert.AreEqual(val.XmlUrl, accessor.Outline.XmlUrl, "RssToolkit.Opml.OutlineInfo.Outline was not set correctly.");
        }

        /// <summary>
        ///A test for OutlineInfo (OpmlOutline, int)
        ///</summary>
        [DeploymentItem("RssToolkit.dll")]
        [TestMethod()]
        public void OpmlOutlineInfoConstructorTest()
        {
            OpmlOutline ol = new OpmlOutline();
            ol.XmlUrl = "http://www.microsoft.com";
            int index = 11;
            object target = RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor.CreatePrivate(ol, index);
            RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor accessor = new RssToolkitUnitTest.RssToolkit_Opml_OutlineInfoAccessor(target);
            Assert.AreEqual(index, accessor.Index, "RssToolkit.Opml.OutlineInfo.Index was not set correctly.");
            Assert.AreEqual(ol.XmlUrl, accessor.Outline.XmlUrl, "RssToolkit.Opml.OutlineInfo.Index was not set correctly.");
        }
    }
}
