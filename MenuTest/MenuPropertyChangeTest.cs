using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest {
    public class MenuPropertyChangeTest {

        #region Entrees

        [Fact]
        public void BrontowurstPropertyChangesShouldWorkProperly() {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () => bw.HoldBun());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldOnion());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldPeppers());
        }

        [Fact]
        public void DinoNuggetsPropertyChangesShouldWorkProperly() {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Price", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Calories", () => dn.AddNugget());

            // This test is to check if the 's' character is added if more than 1 extra nugget is added
            dn.AddNugget();
            Assert.PropertyChanged(dn, "Special", () => dn.AddNugget());
        }

        [Fact]
        public void PrehistoricPBJPropertyChangesShouldWorkProperly() {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldJelly());
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldPeanutButter());
        }

        [Fact]
        public void PterodactylWingsPropertyChangesShouldWorkProperly() {
            // Right now there's nothing in Pterodactyl Wings that would cause a change in
            // any property, but this test method exists for future usage.
        }

        [Fact]
        public void SteakosaurusBurgerPropertyChangesShouldWorkProperly() {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () => sb.HoldBun());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldKetchup());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldMustard());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldPickle());
        }

        [Fact]
        public void TRexKingBurgerPropertyChangesShouldWorkProperly() {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => trex.HoldBun());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldKetchup());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldLettuce());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldMayo());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldMustard());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldOnion());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldPickle());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldTomato());
        }

        [Fact]
        public void VelociWrapPropertyChangesShouldWorkProperly() {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () => vw.HoldCheese());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldDressing());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldLettuce());
        }

        #endregion


        #region Sides

        [Fact]
        public void FryceritopsPropertyChangesShouldWorkProperly() {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Price", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Calories", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Description", () => ft.Size = Size.Large);
        }

        [Fact]
        public void MeteorMacAndCheesePropertyChangesShouldWorkProperly() {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mmc, "Size", () => mmc.Size = Size.Large);
            Assert.PropertyChanged(mmc, "Price", () => mmc.Size = Size.Large);
            Assert.PropertyChanged(mmc, "Calories", () => mmc.Size = Size.Large);
            Assert.PropertyChanged(mmc, "Description", () => mmc.Size = Size.Large);
        }

        [Fact]
        public void MezzorellaSticksPropertyChangesShouldWorkProperly() {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Size", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Price", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Calories", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Description", () => ms.Size = Size.Large);
        }

        [Fact]
        public void TriceritotsPropertyChangesShouldWorkProperly() {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);
        }

        #endregion


        #region Drinks

        [Fact]
        public void JurassicJavaPropertyChangesShouldWorkProperly() {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Size", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Price", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Calories", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Description", () => jj.Size = Size.Large);

            Assert.PropertyChanged(jj, "RoomForCream", () => jj.RoomForCream = true);
            Assert.PropertyChanged(jj, "Special", () => jj.RoomForCream = true);

            Assert.PropertyChanged(jj, "Decaf", () => jj.Decaf = true);
            Assert.PropertyChanged(jj, "Description", () => jj.Decaf = true);

            Assert.PropertyChanged(jj, "Ice", () => jj.Ice = true);
            Assert.PropertyChanged(jj, "Special", () => jj.Ice = true);
        }
        
        [Fact]
        public void SodasaurusPropertyChangesShouldWorkProperly() {
            Sodasaurus ss = new Sodasaurus();
            Assert.PropertyChanged(ss, "Size", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Calories", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Description", () => ss.Size = Size.Large);

            Assert.PropertyChanged(ss, "Description", () => ss.Flavor = SodasaurusFlavor.Cherry);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodasaurusFlavor.Cherry);

            Assert.PropertyChanged(ss, "Ice", () => ss.Ice = true);
            Assert.PropertyChanged(ss, "Special", () => ss.Ice = true);
        }

        [Fact]
        public void TyrannoteaPropertyChangesShouldWorkProperly() {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);

            Assert.PropertyChanged(tt, "Description", () => tt.Sweet = true);
            Assert.PropertyChanged(tt, "Calories", () => tt.Sweet = false);
            Assert.PropertyChanged(tt, "Sweet", () => tt.Sweet = true);

            Assert.PropertyChanged(tt, "Lemon", () => tt.Lemon = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Lemon = true);

            Assert.PropertyChanged(tt, "Ice", () => tt.Ice = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Ice = true);
        }

        [Fact]
        public void WaterPropertyChangesShouldWorkProperly() {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Large);

            Assert.PropertyChanged(w, "Lemon", () => w.Lemon = true);
            Assert.PropertyChanged(w, "Special", () => w.Lemon = true);

            Assert.PropertyChanged(w, "Ice", () => w.Ice = true);
            Assert.PropertyChanged(w, "Special", () => w.Ice = true);
        }

        #endregion


        #region Combos

        [Fact]
        public void CretaceousComboPropertyChangesShouldWorkProperly() {
            CretaceousCombo cc = new CretaceousCombo(new TRexKingBurger());
            Assert.PropertyChanged(cc, "Special", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Entree", () => cc.Entree = new PrehistoricPBJ());

            Assert.PropertyChanged(cc, "Special", () => cc.Side = new MezzorellaSticks());
            Assert.PropertyChanged(cc, "Side", () => cc.Side = new MezzorellaSticks());

            Assert.PropertyChanged(cc, "Special", () => cc.Drink = new Water());
            Assert.PropertyChanged(cc, "Drink", () => cc.Drink = new Water());

            Assert.PropertyChanged(cc, "Toy", () => cc.ChangeToy("Another Toy"));
        }

        #endregion


    }
}
