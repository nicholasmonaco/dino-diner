using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest {
    public class MenuOrderItemTest {

        #region Entrees

        //Descriptions

        [Fact]
        public void BrontowurstDescriptionShouldBeCorrect() {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }


        [Fact]
        public void DinoNuggetDescriptionShouldBeCorrect() {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }


        [Fact]
        public void PrehistoricPBJDescriptionShouldBeCorrect() {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void PterodactylWingsDescriptionShouldBeCorrect() {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionShouldBeCorrect() {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void TRexKingBurgerDescriptionShouldBeCorrect() {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void VelociWrapDescriptionShouldBeCorrect() {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }


        // Special

        [Fact]
        public void BrontowurstSpecialPropertiesShouldWorkProperly() {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);

            bw.HoldBun();
            Assert.Contains<string>("Hold Bun", bw.Special);

            bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Contains<string>("Hold Onion", bw.Special);

            bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Contains<string>("Hold Peppers", bw.Special);

            bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            bw.HoldPeppers();
            Assert.Contains<string>("Hold Bun", bw.Special);
            Assert.Contains<string>("Hold Onion", bw.Special);
            Assert.Contains<string>("Hold Peppers", bw.Special);
        }


        [Fact]
        public void DinoNuggetSpecialPropertiesShouldWorkProperly() {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);

            dn.AddNugget();
            Assert.Contains<string>("Add 1 Extra Nugget", dn.Special);

            dn.AddNugget();
            Assert.Contains<string>("Add 2 Extra Nuggets", dn.Special);
        }


        [Fact]
        public void PrehistoricPBJSpecialPropertiesShouldWorkProperly() {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);

            pbj.HoldPeanutButter();
            Assert.Contains<string>("Hold Peanut Butter", pbj.Special);

            pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Contains<string>("Hold Jelly", pbj.Special);

            pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            pbj.HoldPeanutButter();
            Assert.Contains<string>("Hold Jelly", pbj.Special);
            Assert.Contains<string>("Hold Peanut Butter", pbj.Special);
        }

        [Fact]
        public void PterodactylWingsSpecialPropertiesShouldWorkProperly() {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void SteakosaurusBurgerSpecialPropertiesShouldWorkProperly() {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);

            sb.HoldBun();
            Assert.Contains<string>("Hold Bun", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldMustard();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialPropertiesShouldWorkProperly() {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);

            trex.HoldBun();
            Assert.Contains<string>("Hold Bun", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Contains<string>("Hold Mayo", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.Contains<string>("Hold Mustard", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Contains<string>("Hold Onion", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Contains<string>("Hold Pickle", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Contains<string>("Hold Tomato", trex.Special);

            trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldKetchup();
            trex.HoldLettuce();
            trex.HoldMayo();
            trex.HoldMustard();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldTomato();
            Assert.Contains<string>("Hold Bun", trex.Special);
            Assert.Contains<string>("Hold Ketchup", trex.Special);
            Assert.Contains<string>("Hold Lettuce", trex.Special);
            Assert.Contains<string>("Hold Mayo", trex.Special);
            Assert.Contains<string>("Hold Mustard", trex.Special);
            Assert.Contains<string>("Hold Onion", trex.Special);
            Assert.Contains<string>("Hold Pickle", trex.Special);
            Assert.Contains<string>("Hold Tomato", trex.Special);
        }

        [Fact]
        public void VelociWrapSpecialPropertiesShouldWorkProperly() {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);

            vw.HoldDressing();
            Assert.Contains<string>("Hold Dressing", vw.Special);

            vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", vw.Special);

            vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains<string>("Hold Cheese", vw.Special);

            vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Contains<string>("Hold Dressing", vw.Special);
            Assert.Contains<string>("Hold Lettuce", vw.Special);
            Assert.Contains<string>("Hold Cheese", vw.Special);
        }

        #endregion

        #region Sides

        //Descriptions

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionShouldBeCorrect(Size size) {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionShouldBeCorrect(Size size) {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionShouldBeCorrect(Size size) {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void TriceritotsDescriptionShouldBeCorrect(Size size) {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.Description);
        }

        //Special

        [Fact]
        public void SideSpecialsShouldBeEmpty() {
            Fryceritops ft = new Fryceritops();
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            MezzorellaSticks ms = new MezzorellaSticks();
            Triceritots tt = new Triceritots();

            Assert.Empty(ft.Special);
            Assert.Empty(mmc.Special);
            Assert.Empty(ms.Special);
            Assert.Empty(tt.Special);
        }

        #endregion

        #region Drinks

        //Descriptions

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaReturnsCorrectDescription(Size size, bool decaf) {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }


        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusReturnsCorrectDescription(Size size, SodasaurusFlavor flavor) {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaReturnsCorrectDescription(Size size, bool sweet) {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterReturnsCorrectDescription(Size size) {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        // Special

        [Fact]
        public void JurassicJavaSpecialPropertiesShouldWorkProperly() {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);

            jj.AddIce();
            Assert.Contains<string>("Add Ice", jj.Special);

            jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Contains<string>("Leave Room For Cream", jj.Special);

            jj = new JurassicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Contains<string>("Add Ice", jj.Special);
            Assert.Contains<string>("Leave Room For Cream", jj.Special);
        }

        [Fact]
        public void SodasaurusSpecialPropertiesShouldWorkProperly() {
            Sodasaurus ss = new Sodasaurus();
            Assert.Empty(ss.Special);

            ss.HoldIce();
            Assert.Contains<string>("Hold Ice", ss.Special);
        }

        [Fact]
        public void TyrannoTeaSpecialPropertiesShouldWorkProperly() {
            Tyrannotea tt = new Tyrannotea();
            Assert.Empty(tt.Special);

            tt.HoldIce();
            Assert.Contains<string>("Hold Ice", tt.Special);

            tt = new Tyrannotea();
            tt.AddLemon();
            Assert.Contains<string>("Add Lemon", tt.Special);

            tt = new Tyrannotea();
            tt.HoldIce();
            tt.AddLemon();
            Assert.Contains<string>("Hold Ice", tt.Special);
            Assert.Contains<string>("Add Lemon", tt.Special);
        }

        [Fact]
        public void WaterSpecialPropertiesShouldWorkProperly() {
            Water w = new Water();
            Assert.Empty(w.Special);

            w.HoldIce();
            Assert.Contains<string>("Hold Ice", w.Special);

            w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Add Lemon", w.Special);

            w = new Water();
            w.HoldIce();
            w.AddLemon();
            Assert.Contains<string>("Hold Ice", w.Special);
            Assert.Contains<string>("Add Lemon", w.Special);
        }

        #endregion

        #region Combos

        //Descriptions

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void ComboDescriptionShouldBeCorrect(Type type, string name) {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        //Special

        [Fact]
        public void ComboSpecialShouldBeCorrect() {
            TRexKingBurger e1 = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(e1);
            Assert.Equal("Small Fryceritops", combo.Special[0]);
            Assert.Equal("Small Cola Sodasaurus", combo.Special[1]);

            VelociWrap e2 = new VelociWrap();
            MezzorellaSticks s2 = new MezzorellaSticks();
            JurassicJava d2 = new JurassicJava();
            combo.Entree = e2;
            combo.Side = s2;
            combo.Drink = d2;
            Assert.Equal("Small Mezzorella Sticks", combo.Special[0]);
            Assert.Equal("Small Jurassic Java", combo.Special[1]);

            e2.HoldDressing();
            d2.LeaveRoomForCream();
            Assert.Equal("Hold Dressing", combo.Special[0]);
            Assert.Equal("Small Mezzorella Sticks", combo.Special[1]);
            Assert.Equal("Small Jurassic Java", combo.Special[2]);
            Assert.Equal("Leave Room For Cream", combo.Special[3]);
        }

        #endregion

    }
}
