using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks {
    public class WaterTest {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Water w = new Water();
            Assert.Equal<uint>(0u, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon() {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Water w = new Water();
            w.Size = Size.Large;
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Water w = new Water();
            w.Size = Size.Large;
            w.Size = Size.Small;
            Assert.Equal<uint>(0u, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0u, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0u, w.Calories);
        }

        [Fact]
        public void ShouldHoldIce() {
            Water w = new Water();
            w.Ice = true;
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void ShouldAddLemon() {
            Water w = new Water();
            w.Lemon = false;
            w.AddLemon();
            Assert.True(w.Lemon);
            Assert.Contains<string>("Lemon", w.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients() {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }

    }
}
