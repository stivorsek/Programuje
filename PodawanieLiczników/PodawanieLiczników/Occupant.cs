namespace PodawanieLiczników
{
    public class Occupant
    {
        public string nazwisko { get; private set; }
        public string imie { get; private set; }

        public float gasSum { get; private set; }
        public float wodaSum { get; private set; }
        public float pradSum { get; private set; }
        public Occupant(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.gasSum = 0;
            this.wodaSum = 0;
            this.pradSum = 0;
            
        }

        public void ChoseMedia(char media)
        {
            switch (media)
            {
                case '1':
                    Console.WriteLine("Poniżej podaj nicznik gazu:");
                    var gas = Console.ReadLine();
                    float.TryParse(gas, out float gasNumber);
                    this.GetMediaGas(gasNumber);
                    break;

                case '2':
                    Console.WriteLine("Poniżej podaj nicznik wody:");
                    var aqua = Console.ReadLine();
                    float.TryParse(aqua, out float aquaNumber);
                    this.GetMediaAqua(aquaNumber);
                    break;

                case '3':
                    Console.WriteLine("Poniżej podaj nicznik prądu:");
                    var electricity = Console.ReadLine();
                    float.TryParse(electricity, out float electricityNumber);
                    this.GetMediaPrad(electricityNumber);
                    break;
                default:
                    throw new Exception("Wybrano zły numer proszę wybrać jeden z podany: 1 2 lub 3");


            }

        }
        public void ChoseMedia(string media)
        {
            if (char.TryParse(media, out char mediaNumber))
            {
                this.ChoseMedia(mediaNumber);
            }
            else
            {
                throw new Exception("Podana wartość nie jest cyfrą proszę spróbować jeszcze raz");
            }
        }
        public Gas GetMediaGas(float Gas)
        {
            var wynikGazu = new Gas(Gas);
            var daneGazu = wynikGazu.GetGasConst();
            this.gasSum = daneGazu.gasCost;
            wynikGazu.GetGasConst();
            return wynikGazu;
        }
        public Woda GetMediaAqua(float aqua)
        {
            var wynikWody = new Woda(aqua);
            var daneWody = wynikWody.GetMediaCost();
            this.wodaSum = daneWody.wodaCost;
            wynikWody.GetMediaCost();
            return wynikWody;
        }

        public Prad GetMediaPrad(float electricity)
        {
            var wynikPradu = new Prad(electricity);
            var danePradu = wynikPradu.GetMediaCost();
            this.pradSum = danePradu.pradCost;
            wynikPradu.GetMediaCost();
            return wynikPradu;

        }
  


    }
}
