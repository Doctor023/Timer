using System.Reflection;
using System.Reflection.Emit;
using test;
using Timer;

namespace TimerTests
{
    public class TimerTests
    {
        [Fact]
        public void CreateConstructions_0_trueReturn()
        {
            ConstructionsBuilder constructionsBuilder = new ConstructionsBuilder(1);

            constructionsBuilder.GetConstructionsPlan();
            constructionsBuilder.CreateConstructions();

            Assert.True(constructionsBuilder.HorizontalConstructionPlans.Count > 0);
        }

        [Fact]
        public void Digit_0_trueHorizontalReturn()
        {
            ConstructionsBuilder constructionsBuilder = new ConstructionsBuilder(0);

            constructionsBuilder.GetConstructionsPlan();
            constructionsBuilder.CreateConstructions();

            Assert.True(constructionsBuilder.HorizontalConstructionPlans.Count > 0);
        }
    }
}