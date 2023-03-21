namespace Wyzwanie21dni
{
    public abstract class  Person
    {
        public  Person(string name, string surname, char sex)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }

        public string name { get; private set; }
        public string surname { get; private set; }
        public char sex { get; private set; }
    }

}
