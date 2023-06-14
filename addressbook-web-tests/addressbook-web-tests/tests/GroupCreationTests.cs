using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : BaseClass
    {

        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.OpenGroupPage();
            app.Group.InitGroupCreation();
            app.Group.FillGroupForm(new GroupData("q", "d", "s"));
            app.Group.SubmitGroupCreation();
            app.Navigator.ReturnToGroupPage();
        }

    }
}
