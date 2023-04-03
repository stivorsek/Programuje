namespace PodawanieLiczników
{
    public class Occupant
    {
        public string nazwisko { get; private set; }
        public string imie { get; private set; }

        public Occupant(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void ChoseMedia(char media)
        {
            switch (media)
            {
                case '1':
                    Console.WriteLine("Poniżej podaj nicznik gazu:");
                    var gas = Console.ReadLine();
                    float.TryParse(gas, out float gasNumber);
                    this.MediaGas(gasNumber);
                    break;

                case '2':
                    Console.WriteLine("Poniżej podaj nicznik wody:");
                    var aqua = Console.ReadLine();
                    float.TryParse(aqua, out float aquaNumber);
                    this.MediaAqua(aquaNumber);
                    break;

                case '3':
                    Console.WriteLine("Poniżej podaj nicznik prądu:");
                    var electricity = Console.ReadLine();
                    float.TryParse(electricity, out float electricityNumber);
                    this.MediaElectricity(electricityNumber);
                    break;
                default:
                    throw new Exception("Wybrano zły numer proszę wybrać jeden z podany: 1 2 lub 3");


            }

        }
        public void ChoseMedia(string Media)
        {
            if (char.TryParse(Media, out char mediaNumber))
            {
                 this.ChoseMedia(mediaNumber);
            }
            else
            {
                    throw new Exception("Podana wartość nie jest cyfrą proszę spróbować jeszcze raz");
            }
        }
        public void MediaGas(float Gas)
        {
            var WynikGazu = new Gas(Gas);
        }
        public void MediaAqua(float aqua)
        {
            var WynikWody = new Woda(aqua);
        }

        public void MediaElectricity(float electricity)
        {
            var WynikPradu = new Prad(electricity);
        }
    }
}
