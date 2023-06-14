using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class GroupHelper : BaseHelper
    {

        public GroupHelper(IWebDriver driver) 
            : base(driver)
        {
            
        }

        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }

        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[@value=" + index + "]")).Click();
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void SubmitGroupCreation()
        {
            //submit group creation
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillGroupForm(GroupData group)
        {
            //fill froup form
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        public void InitGroupCreation()
        {
            //init new group creation
            driver.FindElement(By.Name("new")).Click();
        }
    }
}
