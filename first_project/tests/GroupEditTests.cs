using NUnit.Framework;

namespace WebAddressBookTests
{
	[TestFixture]
	public class GroupEditTests : BaseClass
	{

		[Test]
		public void GroupEditTest()
		{
            GroupData newData = new GroupData("ura", "+", "sasha");

            app.Group.Modify(1, newData);


		}
    }
}

