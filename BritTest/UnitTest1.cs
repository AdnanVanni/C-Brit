using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BritTest
{
    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver dr;

        [SetUp]
        public void Setup()
        {
            this.dr = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            dr.Dispose();
        }

        [Test]
        public void TestResults()
        {
            dr.Navigate().GoToUrl("https://www.britinsurance.com/");
            Thread.Sleep(5000);
            dr.FindElement(By.XPath("//button[@aria-label=\"Search button\"]")).Click();
            dr.FindElement(By.Name("k")).SendKeys("ifrs 17");
            dr.FindElement(By.XPath("//button[@aria-label=\"Search button\"]")).Click();
            IList<IWebElement> elements = dr.FindElements(By.ClassName("s-results"));
            int count = elements.Count;
            Assert.AreEqual(8, count);
            IWebElement firstElement = elements.First();
            if (firstElement.Text.Contains("Interim results for the six months ended 30 June 2022"))
            {
                
            }
            else
            {
               
            }
        }
    }
}