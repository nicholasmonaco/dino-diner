/*  JurassicJavaTest.cs
*   Author: Nick Monaco
*/

using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks {

    /// <summary>
    /// A class containing all the tests for the JurassicJava drink.
    /// </summary>
    public class JurassicJavaTest {

        /// <summary>
        /// Tests if the default price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        /// <summary>
        /// Tests if the default calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2u, jj.Calories);
        }

        /// <summary>
        /// Tests if the default ice of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        /// <summary>
        /// Tests if the default size of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        /// <summary>
        /// Tests if the default value of RoomForCream is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream() {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }

        /// <summary>
        /// Tests if the small size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }

        /// <summary>
        /// Tests if the small size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<uint>(2u, jj.Calories);
        }

        /// <summary>
        /// Tests if the medium size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }

        /// <summary>
        /// Tests if the medium size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4u, jj.Calories);
        }

        /// <summary>
        /// Tests if the large size price of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        /// <summary>
        /// Tests if the large size calories of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8u, jj.Calories);
        }

        /// <summary>
        /// Tests if the HoldIce() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldHoldIce() {
            JurassicJava jj = new JurassicJava();
            jj.Ice = true;
            jj.HoldIce();
            Assert.False(jj.Ice);
        }

        /// <summary>
        /// Tests if the LeaveRoomForCream() method of the drink is correct.
        /// </summary>
        [Fact]
        public void ShouldLeaveSpaceForCream() {
            JurassicJava jj = new JurassicJava();
            jj.RoomForCream = false;
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        /// <summary>
        /// Tests if the ingredients of the drink are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients() {
            JurassicJava jj = new JurassicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }


    }
}
