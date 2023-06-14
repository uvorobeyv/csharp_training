using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : BaseClass
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("q", "d", "s");

            app.Group.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("", "", "");

            app.Group.Create(group);
        }

    }
}
