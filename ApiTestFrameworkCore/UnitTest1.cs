using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiTestFrameworkCore
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;

        /// <summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        static readonly HttpClient client = new HttpClient();

        [TestMethod]
        public void TestGetProfile()
        {
            string requestUri = "https://us-central1-mock-backend-60a04.cloudfunctions.net/getProfile";
            var response = client.GetAsync(requestUri).Result;

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            TestContext.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }
}
