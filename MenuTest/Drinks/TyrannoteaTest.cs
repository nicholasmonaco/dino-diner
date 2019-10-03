/*  TyrannoteaTest.cs
*   Author: Nick Monaco
*/

using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks {

    /// <summary>
    /// A class containing all the tests for the Tyrannotea drink.
    /// </summary>
    public class TyrannoteaTest {

        /// <summary>
        /// Tests if the default price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<double>(0.99, tt.Price);
        }

        /// <summary>
        /// Tests if the default calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8u, tt.Calories);
        }

        /// <summary>
        /// Tests if the default ice of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Tyrannotea tt = new Tyrannotea();
            Assert.True(tt.Ice);
        }

        /// <summary>
        /// Tests if the default size of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        /// <summary>
        /// Tests if the default lemon of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon() {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Lemon);
        }

        /// <summary>
        /// Tests if the drink is not sweet by default.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet() {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Sweet);
        }

        /// <summary>
        /// Tests if the small size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal<double>(0.99, tt.Price);
        }

        /// <summary>
        /// Tests if the small size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8u, tt.Calories);
        }

        /// <summary>
        /// Tests if the medium size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<double>(1.49, tt.Price);
        }

        /// <summary>
        /// Tests if the medium size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16u, tt.Calories);
        }

        /// <summary>
        /// Tests if the large size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<double>(1.99, tt.Price);
        }

        /// <summary>
        /// Tests if the large size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32u, tt.Calories);
        }

        /// <summary>
        /// Tests if the HoldIce() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHoldIce() {
            Tyrannotea tt = new Tyrannotea();
            tt.Ice = true;
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        /// <summary>
        /// Tests if the AddLemon() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldAddLemon() {
            Tyrannotea tt = new Tyrannotea();
            tt.Lemon = false;
            tt.AddLemon();
            Assert.True(tt.Lemon);
            Assert.Contains<string>("Lemon", tt.Ingredients);
        }

        /// <summary>
        /// Tests if making the drink sweet works correctly.
        /// </summary>
        [Fact]
        public void ShouldMakeSweet() {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            Assert.True(tt.Sweet);
            Assert.Contains<string>("Cane Sugar", tt.Ingredients);
        }

        /// <summary>
        /// Tests if the calories correctly upscale according to the value of Sweet when the size is small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSweetCalories_Small() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(16u, tt.Calories);
        }

        /// <summary>
        /// Tests if the calories correctly upscale according to the value of Sweet when the size is medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSweetCalories_Medium() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(32u, tt.Calories);
        }

        /// <summary>
        /// Tests if the calories correctly upscale according to the value of Sweet when the size is large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSweetCalories_Large() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(64u, tt.Calories);
        }

        /// <summary>
        /// Tests if the calories change correctly according to the value of Sweet when the size is small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectResetCalories_Small() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(16u, tt.Calories);

            tt.Sweet = false;
            Assert.Equal<uint>(8u, tt.Calories);
        }

        /// <summary>
        /// Tests if the calories change correctly according to the value of Sweet when the size is medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectResetCalories_Medium() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(32u, tt.Calories);

            tt.Sweet = false;
            Assert.Equal<uint>(16u, tt.Calories);
        }

        /// <summary>
        /// Tests if the calories change correctly according to the value of Sweet when the size is large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectResetCalories_Large() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(64u, tt.Calories);

            tt.Sweet = false;
            Assert.Equal<uint>(32u, tt.Calories);
        }

        /// <summary>
        /// Tests if the ingredients of the drink are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Equal<int>(2, tt.Ingredients.Count);
        }

    }
}
