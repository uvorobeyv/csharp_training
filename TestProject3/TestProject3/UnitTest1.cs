using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject3
{
    public class Tests
    {
        protected IWebDriver driver;
        string url = "http://ya.ru";
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
           driver.Navigate().GoToUrl(url);
        }
    }
}