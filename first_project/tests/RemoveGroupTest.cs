using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class RemoveGroupTest : BaseClass
    {
        

        [Test]
        public void TheUntitledTestCaseTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.OpenGroupPage();
            app.Group.SelectGroup(9);
            app.Group.RemoveGroup();
            app.Navigator.ReturnToGroupPage();
        }

        
    }
}
