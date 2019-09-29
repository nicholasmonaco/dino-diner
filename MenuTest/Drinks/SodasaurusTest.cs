using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks {
    public class SodasaurusTest {

        [Fact]
        public void CanSetCherry() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, ss.Flavor);
        }

        [Fact]
        public void CanSetChocolate() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, ss.Flavor);
        }

        [Fact]
        public void CanSetCola() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, ss.Flavor);
        }

        [Fact]
        public void CanSetLime() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ss.Flavor);
        }

        [Fact]
        public void CanSetOrange() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, ss.Flavor);
        }

        [Fact]
        public void CanSetRootBeer() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, ss.Flavor);
        }

        [Fact]
        public void CanSetVanilla() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, ss.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<double>(1.50, ss.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<uint>(112u, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Sodasaurus ss = new Sodasaurus();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            ss.Size = Size.Small;
            Assert.Equal<double>(1.50, ss.Price);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            ss.Size = Size.Small;
            Assert.Equal<uint>(112u, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<double>(2.00, ss.Price);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(156u, ss.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<double>(2.50, ss.Price);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<uint>(208u, ss.Calories);
        }

        [Fact]
        public void ShouldHoldIce() {
            Sodasaurus ss = new Sodasaurus();
            ss.Ice = true;
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Contains<string>("Water", ss.Ingredients);
            Assert.Contains<string>("Natural Flavors", ss.Ingredients);
            Assert.Contains<string>("Cane Sugar", ss.Ingredients);
            Assert.Equal<int>(3, ss.Ingredients.Count);
        }

    }
}
