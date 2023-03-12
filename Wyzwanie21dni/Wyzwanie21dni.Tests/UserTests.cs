namespace Wyzwanie21dni.Tests

{
    public class Tests
    {
        [Test]
        public void WhenUserGetThreeScores_ShoultReturnSumAsResult()
        {

            //arrange
            var user = new User("Damian", "1234");
            user.AddScore(4);
            user.AddScore(5);
            user.AddScore(6);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(15, result);
        }
        [Test]
        public void WhenUserGetMinusSum_ShoultBeTrue()
        {

            //arrange
            var user = new User("Damian", "1234");
            user.AddScore(4);
            user.AddScore(-5);
            //act
            int result = user.Result;
            //assert
            Assert.LessOrEqual(result, 0);
        }
        [Test]
        public void WhenUserGetBigerScoreThen20_ShoultBePromoted()
        {

            //arrange
            var user = new User("Damian", "1234");
            user.AddScore(15);
            user.AddScore(10);
            //act
            var result = user.Result;
            //assert
            Assert.Greater(result, 20);
        }

    }
}