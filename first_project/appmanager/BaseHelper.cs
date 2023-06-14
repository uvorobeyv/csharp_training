using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class BaseHelper
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;

        public BaseHelper(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}
