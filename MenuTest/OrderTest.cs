using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest {
    public class OrderTest {

        [Fact]
        public void OrderSubtotalCostShouldBeCorrect() {
            Order up = new Order();

            Brontowurst bw1 = new Brontowurst();
            Fryceritops ft1 = new Fryceritops();
            Fryceritops ft2 = new Fryceritops();
            ft2.Size = Size.Medium;
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;

            up.Items.Add(bw1);
            up.Items.Add(ft1);
            up.Items.Add(ft2);
            up.Items.Add(ss);

            double expectedSubtotal = bw1.Price + ft1.Price + ft2.Price + ss.Price;

            Assert.Equal(expectedSubtotal, up.SubtotalCost);
        }

        [Fact]
        public void OrderSubtotalCostCannotBeNegative() {
            Order up = new Order();

            Brontowurst bw1 = new Brontowurst();
            Fryceritops ft1 = new Fryceritops();
            Fryceritops ft2 = new Fryceritops();
            ft2.Price = -5000;

            up.Items.Add(bw1);
            up.Items.Add(ft1);
            up.Items.Add(ft2);

            Assert.True(up.SubtotalCost >= 0);
        }

        [Fact]
        public void OrderSalesTaxCostShouldBeCorrect() {
            Order up = new Order();

            Brontowurst bw1 = new Brontowurst();
            Fryceritops ft1 = new Fryceritops();
            Fryceritops ft2 = new Fryceritops();
            ft2.Size = Size.Medium;
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;

            up.Items.Add(bw1);
            up.Items.Add(ft1);
            up.Items.Add(ft2);
            up.Items.Add(ss);

            double salesTaxCost = (bw1.Price + ft1.Price + ft2.Price + ss.Price) * up.SalesTaxRate;

            Assert.Equal(salesTaxCost, up.SalesTaxCost);
        }

        [Fact]
        public void OrderTotalCostShouldBeCorrect() {
            Order up = new Order();

            Brontowurst bw1 = new Brontowurst();
            Fryceritops ft1 = new Fryceritops();
            Fryceritops ft2 = new Fryceritops();
            ft2.Size = Size.Medium;
            Sodasaurus ss = new Sodasaurus();
            ss.Size = Size.Large;

            up.Items.Add(bw1);
            up.Items.Add(ft1);
            up.Items.Add(ft2);
            up.Items.Add(ss);

            double expectedSubtotal = bw1.Price + ft1.Price + ft2.Price + ss.Price;
            double salesTaxCost = (bw1.Price + ft1.Price + ft2.Price + ss.Price) * up.SalesTaxRate;

            Assert.Equal(expectedSubtotal+salesTaxCost, up.TotalCost);
        }

    }
}
