/*  WaterTest.cs
*   Author: Nick Monaco
*/

using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks {

    /// <summary>
    /// A class containing all the tests for the Water drink.
    /// </summary>
    public class WaterTest {

        /// <summary>
        /// Tests if the default price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests if the default calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Water w = new Water();
            Assert.Equal<uint>(0u, w.Calories);
        }

        /// <summary>
        /// Tests if the default ice of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        /// <summary>
        /// Tests if the default size of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        /// <summary>
        /// Tests if the default lemon of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon() {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// Tests if the small size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Water w = new Water();
            w.Size = Size.Large;
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests if the small size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Water w = new Water();
            w.Size = Size.Large;
            w.Size = Size.Small;
            Assert.Equal<uint>(0u, w.Calories);
        }

        /// <summary>
        /// Tests if the medium size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests if the medium size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0u, w.Calories);
        }

        /// <summary>
        /// Tests if the large size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests if the large size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0u, w.Calories);
        }

        /// <summary>
        /// Tests if the HoldIce() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHoldIce() {
            Water w = new Water();
            w.Ice = true;
            w.HoldIce();
            Assert.False(w.Ice);
        }

        /// <summary>
        /// Tests if the AddLemon() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldAddLemon() {
            Water w = new Water();
            w.Lemon = false;
            w.AddLemon();
            Assert.True(w.Lemon);
            Assert.Contains<string>("Lemon", w.Ingredients);
        }

        /// <summary>
        /// Tests if the ingredients of the drink are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients() {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }

    }
}
