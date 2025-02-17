using Xunit;
using ConsoleProject;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAccept()
        {
            CalController calController = new CalController();

            Assert.Equal(3, calController.Add(1, 2));
        }

        [Fact]
        public void TestFail()
        {
            CalController calController = new CalController();

            Assert.Equal(3, calController.Add(1, 2));
        }
    }
}
