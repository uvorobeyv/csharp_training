using OpenQA.Selenium;
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
            loginHelper = new LoginHelper(driver);
            navigator = new NavigatorHelper(driver, baseURL);
            group = new GroupHelper(driver);
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
