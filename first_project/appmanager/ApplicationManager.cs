using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace WebAddressBookTests
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigatorHelper navigator;
        protected GroupHelper group;

        protected IWebDriver driver;
        protected string baseURL;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/index.php";
            loginHelper = new LoginHelper(this);
            navigator = new NavigatorHelper(this, baseURL);
            group = new GroupHelper(this);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigatorHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public GroupHelper Group
        {
            get
            {
                return group;
            }
        }

        
    }
}
