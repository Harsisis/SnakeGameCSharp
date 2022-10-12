using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.entity {
    [TestClass]
    public class PlayerTest {
        [TestMethod]
        public void ThrowDice_CheckOvercome() {
            Player player = new Player("Martin");
            player.playerCase = 50;

            player.ThrowDice(50, 25);

            Assert.AreEqual(25, player.playerCase);
        }

        [TestMethod]
        public void CheckPlayerPosition_Win() {
            Player player = new Player("Martin");
            player.playerCase = 50;

            Assert.IsTrue(player.CheckPlayerPosition(50, 25));
        }

        [TestMethod]
        public void CheckPlayerPosition_OvercomeOrNothing() {
            Player player = new Player("Martin");

            player.playerCase = 10;
            Assert.IsFalse(player.CheckPlayerPosition(50, 25));

            player.playerCase = 55;
            Assert.IsFalse(player.CheckPlayerPosition(50, 25));
        }
    }
}
