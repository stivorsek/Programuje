
namespace Wyzwanie21dni
{
    public class User
    {

        private List<int> score = new List<int>();
        public User(string login, string pasword)
        {
            this.Login = login;
            this.Password = pasword;
        }


        public string Login { get; set; }

        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
