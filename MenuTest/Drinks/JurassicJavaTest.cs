using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks {
    public class JurassicJavaTest {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2u, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream() {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<uint>(2u, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4u, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8u, jj.Calories);
        }

        [Fact]
        public void ShouldHoldIce() {
            JurassicJava jj = new JurassicJava();
            jj.Ice = true;
            jj.HoldIce();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldLeaveSpaceForCream() {
            JurassicJava jj = new JurassicJava();
            jj.RoomForCream = false;
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }


    }
}
