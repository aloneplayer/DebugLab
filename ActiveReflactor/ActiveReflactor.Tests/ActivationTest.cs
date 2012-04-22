using ActiveReflactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Text;

namespace ActiveReflactor.Tests
{
    /// <summary>
    ///This is a test class for ActivationTest and is intended
    ///to contain all ActivationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ActivationTest
    {
        private const string SN = "A3KE-ABCD-ABCD-ABCD-ABCD-ABCD";
        private const string SESSION_ID = "ecaf103a-f433-42fa-b035-2bf892ab8023";

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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetSNFromRequest
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void GetSNFromRequestTest()
        {
            Activation target = new Activation(); // TODO: Initialize to an appropriate value
            string request = BuildRequst(SN, SESSION_ID); // TODO: Initialize to an appropriate value
            string expected = SN; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetSNFromRequest(request);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetSessionFromRequest
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void GetSessionFromRequestTest()
        {
            Activation target = new Activation(); // TODO: Initialize to an appropriate value
            string request = BuildRequst(SN, SESSION_ID); // TODO: Initialize to an appropriate value
            string expected = SESSION_ID; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetSessionFromRequest(request);
            Assert.AreEqual(expected, actual);
        }

        private string BuildRequst(string sn, string sessionId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<version>3</version>");
            sb.Append("<machinehash>0DF8-01F1-42F5-78A3</machinehash>");
            sb.Append("<productcode>24</productcode>");
            sb.Append("<majorversion>7</majorversion>");
            sb.Append("<minorversion>0</minorversion>");
            sb.AppendFormat("<serialnumber>{0}</serialnumber>", sn);
            sb.AppendFormat("<session>{0}</session>", sessionId);
            sb.Append("<locale>en-US</locale>");

            return sb.ToString();
        }
    }
}
