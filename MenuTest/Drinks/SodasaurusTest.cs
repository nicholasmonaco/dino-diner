/*  SodasaurusTest.cs
*   Author: Nick Monaco
*/

using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks {

    /// <summary>
    /// A class containing all the tests for the Sodasaurus drink.
    /// </summary>
    public class SodasaurusTest {

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetCherry() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetChocolate() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetCola() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetLime() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetOrange() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetRootBeer() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, ss.Flavor);
        }

        /// <summary>
        /// Checks if the Sodasaurus sets the specified flavor correctly.
        /// </summary>
        [Fact]
        public void CanSetVanilla() {
            Sodasaurus ss = new Sodasaurus();
            ss.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, ss.Flavor);
        }

        /// <summary>
        /// Tests if the default price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<double>(1.50, ss.Price);
        }

        /// <summary>
        /// Tests if the default calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<uint>(112u, ss.Calories);
        }

        /// <summary>
        /// Tests if the default ice of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Sodasaurus ss = new Sodasaurus();
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests if the default size of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests if the small size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            ss.Size = Size.Small;
            Assert.Equal<double>(1.50, ss.Price);
        }

        /// <summary>
        /// Tests if the small size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            ss.Size = Size.Small;
            Assert.Equal<uint>(112u, ss.Calories);
        }

        /// <summary>
        /// Tests if the medium size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<double>(2.00, ss.Price);
        }

        /// <summary>
        /// Tests if the medium size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Medium;
            Assert.Equal<uint>(156u, ss.Calories);
        }

        /// <summary>
        /// Tests if the large size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<double>(2.50, ss.Price);
        }

        /// <summary>
        /// Tests if the large size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;
            Assert.Equal<uint>(208u, ss.Calories);
        }

        /// <summary>
        /// Tests if the HoldIce() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHoldIce() {
            Sodasaurus ss = new Sodasaurus();
            ss.Ice = true;
            ss.HoldIce();
            Assert.False(ss.Ice);
        }

        /// <summary>
        /// Tests if the ingredients of the drink are correct.
        /// </summary>
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
