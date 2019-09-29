using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks {
    public class TyrannoteaTest {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<double>(0.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8u, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce() {
            Tyrannotea tt = new Tyrannotea();
            Assert.True(tt.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon() {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSweet() {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Sweet);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal<double>(0.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectSmallSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8u, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<double>(1.49, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectMediumSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16u, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizePrice() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<double>(1.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectLargeSizeCalories() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32u, tt.Calories);
        }

        [Fact]
        public void ShouldHoldIce() {
            Tyrannotea tt = new Tyrannotea();
            tt.Ice = true;
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        [Fact]
        public void ShouldAddLemon() {
            Tyrannotea tt = new Tyrannotea();
            tt.Lemon = false;
            tt.AddLemon();
            Assert.True(tt.Lemon);
            Assert.Contains<string>("Lemon", tt.Ingredients);
        }

        [Fact]
        public void ShouldMakeSweet() {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            Assert.True(tt.Sweet);
            Assert.Contains<string>("Cane Sugar", tt.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectSweetCalories_Small() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(16u, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectSweetCalories_Medium() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(32u, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectSweetCalories_Large() {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32u, tt.Calories);

            tt.Sweet = true;
            Assert.Equal<uint>(64u, tt.Calories);
        }

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

        [Fact]
        public void ShouldHaveCorrectIngredients() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Equal<int>(2, tt.Ingredients.Count);
        }

    }
}
