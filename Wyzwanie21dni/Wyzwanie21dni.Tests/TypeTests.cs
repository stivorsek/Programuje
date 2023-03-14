
namespace Wyzwanie21dni.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestWartosciowyStingow()
        {

            //arrange
            string number1 = "Damian";
            string number2 = "Damian";
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void TestRefencyjny()
        {

            //arrange
            var user1 = new User("Damian", "Haslo");
            var user2 = new User("Damian", "Takie");
            //act

            //assert
            Assert.AreNotEqual(user1.Password, user2.Password);
        }


        [Test]
        public void TestWartosciowyFloatow()
        {

            //arrange
            float WartoscFloat1 = 13;
            float WartoscFloat2 = 16;
            //act

            //assert
            Assert.Greater(WartoscFloat2, WartoscFloat1);
        }


        [Test]
        public void TestWartosciowyBoolow()
        {

            //arrange
            bool WartoscBool1 = false;
            bool WartoscBool2 = true;
            //act

            //assert
            Assert.AreNotEqual(WartoscBool2, WartoscBool1);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
