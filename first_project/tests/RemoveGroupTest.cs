using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class RemoveGroupTest : BaseClass
    {
        

        [Test]
        public void TheUntitledTestCaseTest()
        {
            app.Navigator.OpenGroupPage();
            app.Group
                .SelectGroup(9)
                .RemoveGroup();
            app.Navigator.ReturnToGroupPage();
        }

        
    }
}
