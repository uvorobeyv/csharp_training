using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class GroupHelper : BaseHelper
    {

        public GroupHelper(ApplicationManager manager) 
            : base(manager)
        {
            
        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.OpenGroupPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            manager.Navigator.ReturnToGroupPage();

            return this;
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.OpenGroupPage();
            manager.Group.SelectGroup(v);
            InitEditGroup();
            manager.Group.FillGroupForm(newData);
            UpdateGroupForm();
            manager.Navigator.ReturnToGroupPage();
            return this;
        }

        public GroupHelper UpdateGroupForm()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitEditGroup()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[@value=" + index + "]")).Click();
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            //submit group creation
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
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
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            //init new group creation
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        
    }
}
