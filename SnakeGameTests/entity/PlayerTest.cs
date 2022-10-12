namespace SnakeGame.entity {
    [TestClass]
    public class PlayerTest {

        public Player player { get; set; }
        public PlayerTest() {
            player = new Player("Martin");
            player.playerCase = 50;
        }

        [TestMethod]
        public void ThrowDice_CheckOvercome() {
            player.ThrowDice(50, 25);
            Assert.AreEqual(25, player.playerCase);
        }

        [TestMethod]
        public void CheckPlayerPosition_Win() {
            Assert.IsTrue(player.CheckPlayerPosition(50, 25));
        }

        [TestMethod]
        public void CheckPlayerPosition_OvercomeOrNothing() {
            player.playerCase = 10;
            Assert.IsFalse(player.CheckPlayerPosition(50, 25));

            player.playerCase = 55;
            Assert.IsFalse(player.CheckPlayerPosition(50, 25));
        }
    }
}
